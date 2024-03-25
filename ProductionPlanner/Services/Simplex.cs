using ProductionPlanner.Model;

namespace ProductionPlanner.Services
{
    public enum SimplexResult { Unbounded, Found, NotYetFound }
    
    public class Simplex
    {
        Function function;

        double[] functionVariables; //biến hàm mục tiêu
        double[][] matrix; //ma trận ràng buộc các biến
        double[] b; //vế phải các phương trình ràng buộc
        bool[] m; //đánh dấu là biến cơ bản
        double[] M; // mảng hệ số của biến cơ bản
        double[] F; // mảng hệ số của biến không cơ bản (biến phụ)
        int[] C; //mảng chứa chỉ số biến cơ bản
        bool isMDone = false;
        public Simplex(Function function, Constraint[] constraints)
        {
            if (function.isExtrMax)
            {
                this.function = function;
            } else
            {
                this.function = Canonize(function);
            }

            getMatrix(constraints);
            getFunctionArray();
            getMandF();

            for(int i = 0; i < F.Length; i++)
            {
                F[i] = -functionVariables[i];
            }

        }

        public Tuple<List<SimplexSnap>, SimplexResult> GetResult()
        {
            List<SimplexSnap> snaps = new List<SimplexSnap>();
            snaps.Add(new SimplexSnap(b, matrix, M, F, C, functionVariables, isMDone,m));

            SimplexIndexResult result = nextStep();
            int i = 0;
            while (result.result == SimplexResult.NotYetFound && i < 100)
            {
                calculateSimplexTableau(result.index);
                snaps.Add(new SimplexSnap(b, matrix, M, F, C, functionVariables, isMDone, m));
                result = nextStep();
                i++;
            }

            return new Tuple<List<SimplexSnap>, SimplexResult>(snaps,result.result);
        }

        //tính toán bảng Simplex mới dựa trên kết quả của bước Simplex trước đó
        void calculateSimplexTableau(Tuple<int,int> Xij)
        {
            double[][] newMatrix = new double[matrix.Length][];

            C[Xij.Item2] = Xij.Item1;

            double[] newJRow = new double[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                newJRow[i] = matrix[i][Xij.Item2] / matrix[Xij.Item1][Xij.Item2];
            }

            double[] newB = new double[b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                if (i == Xij.Item2)
                {
                    newB[i] = b[i] / matrix[Xij.Item1][Xij.Item2];
                }
                else
                {
                    newB[i] = b[i] - b[Xij.Item2] / matrix[Xij.Item1][Xij.Item2] * matrix[Xij.Item1][i];
                }
            }

            b = newB;

            for (int i = 0; i < matrix.Length; i++)
            {
                newMatrix[i] = new double[C.Length];
                for (int j = 0; j < C.Length; j++)
                {
                    if(j == Xij.Item2)
                    {
                        newMatrix[i][j] = newJRow[i];
                    } else
                    {
                        newMatrix[i][j] = matrix[i][j] - newJRow[i] * matrix[Xij.Item1][j];
                    }
                }
            }

            matrix = newMatrix;
            getMandF();
        }

        void getMandF()
        {
            M = new double[matrix.Length];
            F = new double[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                double sumF = 0;
                double sumM = 0;
                for (int j = 0; j < matrix.First().Length; j++)
                {
                    if (m[C[j]])
                    {
                        sumM -= matrix[i][j];
                    }
                    else
                    {
                        sumF += functionVariables[C[j]] * matrix[i][j];
                    }
                }
                M[i] = m[i] ? sumM +1 : sumM;
                F[i] = sumF - functionVariables[i];
            }
        }

        //tiến hành một bước Simplex tiếp theo và lưu trữ kết quả trong đối tượng result
        SimplexIndexResult nextStep()
        {

            int columnM = getIndexOfNegativeElementWithMaxAbsoluteValue(M);

            if (isMDone || columnM == -1)
            {
                //M doesn't have negative values
                isMDone = true;
                int columnF = getIndexOfNegativeElementWithMaxAbsoluteValue(F);

                if (columnF != -1) //Has at least 1 negative value
                {
                    int row = getIndexOfMinimalRatio(matrix[columnF], b);

                    if (row != -1)
                    {
                        return new SimplexIndexResult(new Tuple<int, int>(columnF, row), SimplexResult.NotYetFound);
                    }
                    else
                    {
                        return new SimplexIndexResult(null, SimplexResult.Unbounded);
                    }
                }
                else
                {
                    return new SimplexIndexResult(null, SimplexResult.Found);
                }
                
            } else
            {
                int row = getIndexOfMinimalRatio(matrix[columnM], b);

                if (row != -1)
                {
                    return new SimplexIndexResult(new Tuple<int, int>(columnM, row), SimplexResult.NotYetFound);
                }
                else
                {
                    return new SimplexIndexResult(null, SimplexResult.Unbounded);
                }
            }
        }
        
        int getIndexOfNegativeElementWithMaxAbsoluteValue(double[] array)
        {
            int index = -1;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (!isMDone || isMDone && !m[i])
                    {
                        if (index == -1)
                        {
                            index = i;
                        }
                        else if (Math.Abs(array[i]) > Math.Abs(array[index]))
                        {
                            index = i;
                        }
                    }

                }
            }
            return index;
        }

        int getIndexOfMinimalRatio(double[] column, double[] b)
        {
            int index = -1;

            for (int i = 0; i < column.Length; i++)
            {
                if(column[i] > 0 && b[i] > 0)
                {
                    if (index == -1)
                    {
                        index = i;
                    }
                    else if(b[i] / column[i] < b[index] / column[index])
                    {
                        index = i;
                    }
                }
            }

            return index;
        }

        public void getFunctionArray() {
            double[] funcVars = new double[matrix.Length];
            for(int i = 0; i < matrix.Length; i++) {
                funcVars[i] = i < function.variables.Length ? function.variables[i] : 0;
            }
            this.functionVariables = funcVars;
        }

        public Function Canonize(Function function)
        {
            double[] newFuncVars = new double[function.variables.Length];

            for (int i = 0; i < function.variables.Length; i++)
            {
                newFuncVars[i] = -function.variables[i];
            }
            return new Function(newFuncVars, -function.c, true);
        }

        double[][] appendColumn(double[][] matrix, double[] column)
        {
            double[][] newMatrix = new double[matrix.Length + 1][];
            for (int i = 0; i < matrix.Length; i++)
            {
                newMatrix[i] = matrix[i];
            }
            newMatrix[matrix.Length] = column;
            return newMatrix;
        }

        T[] append<T>(T[] array, T element)
        {
            T[] newArray = new T[array.Length + 1];
            for(int i = 0; i<array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = element;
            return newArray;
        }

        double[] getColumn(double value, int place, int length)
        {
            double[] newColumn = new double[length];

            for (int k = 0; k < length; k++)
            {
                newColumn[k] = k == place ? value : 0;
            }

            return newColumn;
        }

        public void getMatrix(Constraint[] constraints)
        {
            for (int i = 0; i < constraints.Length; i++)
            {
                if (constraints[i].b < 0)
                {
                    double[] cVars = new double[constraints[i].variables.Length];

                    for (int j = 0; j < constraints[i].variables.Length; j++)
                    {
                        cVars[j] = -constraints[i].variables[j];
                    }

                    string sign = constraints[i].sign;

                    if (sign == ">=")
                    {
                        sign = "<=";
                    }
                    else if (sign == "<=")
                    {
                        sign = ">=";
                    }

                    Constraint cNew = new Constraint(cVars, -constraints[i].b, sign);
                    constraints[i] = cNew;
                }
            }

            double[][] matrix = new double[constraints.First().variables.Length][];

            for(int i = 0; i < constraints.First().variables.Length; i++)
            {
                matrix[i] = new double[constraints.Length];
                for(int j = 0; j < constraints.Length; j++)
                {
                    matrix[i][j] = constraints[j].variables[i];
                }
            }

            double[][] appendixMatrix = new double[0][];
            double[] Bs = new double[constraints.Length];

            for (int i = 0; i < constraints.Length; i++)
            {
                Constraint current = constraints[i];

                Bs[i] = current.b;

                if (current.sign == ">=")
                {
                    appendixMatrix = appendColumn(appendixMatrix, getColumn(-1, i, constraints.Length));
                } else if (current.sign == "<=")
                {
                    appendixMatrix = appendColumn(appendixMatrix, getColumn(1, i, constraints.Length));
                }
            }

            double[][] newMatrix = new double[constraints.First().variables.Length + appendixMatrix.Length][];

            for(int i = 0; i < constraints.First().variables.Length; i++)
            {
                newMatrix[i] = matrix[i];
            }

            for (int i = constraints.First().variables.Length; i < constraints.First().variables.Length + appendixMatrix.Length; i++)
            {
                newMatrix[i] = appendixMatrix[i - constraints.First().variables.Length];
            }

            bool[] hasBasicVar = new bool[constraints.Length];

            for(int i = 0; i < constraints.Length; i++) {
                hasBasicVar[i] = false;
            }

            C = new int[constraints.Length];

            int ci = 0;
            for(int i = 0; i < newMatrix.Length; i++) {


                bool hasOnlyNulls = true;
                bool hasOne = false;
                Tuple<int,int> onePosition = new Tuple<int, int>(0,0);
                for(int j = 0; j < constraints.Length; j++) {


                    if (newMatrix[i][j] == 1)
                    {
                        if (hasOne) {
                            hasOnlyNulls = false;
                            break;
                        } else {
                            hasOne = true;
                            onePosition = new Tuple<int, int>(i,j);
                        }
                    }
                    else if (newMatrix[i][j] != 0)
                    {
                        hasOnlyNulls = false;
                        break;
                    }


                }

                if (hasOnlyNulls && hasOne) {
                    hasBasicVar[onePosition.Item2] = true;
                    C[ci] = onePosition.Item1;
                    ci++;
                }
                
            }

            m = new bool[newMatrix.Length];

            for(int i = 0; i < newMatrix.Length; i++)
            {
                m[i] = false;
            }

            for(int i = 0; i < constraints.Length; i++) {
                
                if(!hasBasicVar[i]) {

                    double[] basicColumn = new double[constraints.Length];    

                    for(int j = 0; j < constraints.Length; j++) {
                        basicColumn[j] = j == i ? 1 : 0;
                    }    

                    newMatrix = appendColumn(newMatrix,basicColumn);
                    m = append(m, true);
                    C[ci] = newMatrix.Length - 1;
                    ci++;
                }
                
            }

            this.b = Bs;
            this.matrix = newMatrix;
        } 
    }
}
/*
 Các biến thành viên:

function: Đại diện cho hàm mục tiêu cần tối ưu.
functionVariables: Mảng các biến của hàm mục tiêu.
matrix: Ma trận ràng buộc của các biến.
b: Mảng các giá trị bên phải của các ràng buộc.
m: Mảng boolean đánh dấu các biến cơ bản.
M: Mảng chứa tổng các hệ số của biến cơ bản trong các ràng buộc.
F: Mảng chứa tổng các hệ số của biến không cơ bản trong các ràng buộc.
C: Mảng chứa chỉ số của biến cơ bản trong ma trận.
isMDone: Boolean đánh dấu xem việc tính toán M đã hoàn thành hay chưa.
Phương thức khởi tạo:

Simplex(Function function, Constraint[] constraints): Nhận vào một hàm mục tiêu và một mảng các ràng buộc, tiến hành chuẩn hóa hàm mục tiêu (nếu cần) và xây dựng ma trận ràng buộc.
Phương thức GetResult():

Trả về một Tuple chứa danh sách các bước tính toán giữa các bảng Simplex và kết quả cuối cùng của thuật toán Simplex.
Các phương thức hỗ trợ:

calculateSimplexTableau(Tuple<int, int> Xij): Tính toán bảng Simplex mới dựa trên chỉ số Xij cho biến cơ bản.
getMandF(): Tính toán các mảng M và F dựa trên ma trận và các biến.
nextStep(): Thực hiện bước tiếp theo của thuật toán Simplex để tìm kiếm biến cơ bản tiếp theo.
getIndexOfNegativeElementWithMaxAbsoluteValue(double[] array): Trả về chỉ số của phần tử âm có giá trị tuyệt đối lớn nhất trong một mảng.
getIndexOfMinimalRatio(double[] column, double[] b): Trả về chỉ số của phần tử nhỏ nhất trong tỷ lệ của một cột với mảng b.
getFunctionArray(): Xây dựng mảng functionVariables từ hàm mục tiêu.
Canonize(Function function): Chuẩn hóa hàm mục tiêu (đảo dấu hệ số).
appendColumn(double[][] matrix, double[] column): Thêm một cột vào ma trận.
append<T>(T[] array, T element): Thêm một phần tử vào một mảng.
getColumn(double value, int place, int length): Tạo một cột mới với giá trị xác định tại một vị trí cụ thể.
 */
