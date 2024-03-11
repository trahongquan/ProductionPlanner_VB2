namespace ProductionPlanner.Model
{
    public class Problem
    {
        //Lớp này đại diện cho bài toán tối ưu hóa.
        //Nó lưu trữ thông tin về ma trận ràng buộc, hệ số của hàm mục tiêu và các biến khác liên quan

        public double[][] consMatrx;
        public string[] signs;
        public double[] freeVars;
        public double[] funcVars;
        public double c;
        public bool isExtrMax;

        public Problem(double[][] constraintMatrix, string[] signs, double[] freeVariables, double[] functionVariables, double c, bool isExtrMax)
        {
            this.consMatrx = constraintMatrix;
            this.signs = signs;
            this.freeVars = freeVariables;
            this.funcVars = functionVariables;
            this.c = c;
            this.isExtrMax = isExtrMax;
        }
    }
}
