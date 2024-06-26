﻿using System.Linq;

namespace ProductionPlanner.Model
{
    public class SimplexSnap
    {
        //Lớp này đại diện cho một bước trung gian trong thuật toán Simplex.
        //Nó lưu trữ trạng thái của ma trận Simplex và các biến khác liên quan trong quá trình giải quyết bài toán tối ưu.
        //Nó cung cấp phương thức để sao chép mảng và ma trận.

        public double[] b;
        public double[][] matrix;
        public double[] M;
        public double[] F;
        public int[] C;
        public double fValue;
        public double[] fVars;
        public bool isMDone;
        public bool[] m;

        public SimplexSnap(double[] b, double[][] matrix, double[] M, double[] F, int[] C, double[] fVars, bool isMDone, bool[] m)
        {
            this.b = Copy(b);
            this.matrix = Copy(matrix);
            this.M = Copy(M);
            this.F = Copy(F);
            this.C = Copy(C);
            this.isMDone = isMDone;
            this.m = Copy(m);
            this.fVars = Copy(fVars);
            fValue = 0;
            for (int i = 0; i < C.Length; i++)
            {
                fValue += fVars[C[i]] * b[i];
            }
        }

        T[] Copy<T>(T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            return newArr;
        }

        T[][] Copy<T>(T[][] matrix)
        {
            T[][] newMatr = new T[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                newMatr[i] = new T[matrix.First().Length];
                for (int j = 0; j < matrix.First().Length; j++)
                {
                    newMatr[i][j] = matrix[i][j];
                }
            }
            return newMatr;
        }
    }
}
