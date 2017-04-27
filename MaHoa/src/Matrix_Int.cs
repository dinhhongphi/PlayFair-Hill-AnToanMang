using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa
{
    public class Matrix_Int
    {
        protected int[,] matrix;
        protected int N_matrix; //size of matrix

        public Matrix_Int(int n)
        {
            N_matrix = n;
            matrix = new int[N_matrix, N_matrix];
        }

        public int Get(int i, int j)
        {
            return matrix[i, j];
        }

        public int Get(Coordinate cor)
        {
            return matrix[cor.I, cor.J];
        }

        /// <summary>
        /// create Inverse matrix from this
        /// </summary>
        protected void CreateInverseMatrix()
        {


        }
        /// <summary>
        /// caculator determinant of this
        /// </summary>
        /// <returns></returns>
        public float Determinant()
        {
            if (this.N_matrix == 2)
            {
                return this.matrix[0, 0] * this.matrix[1, 1] - this.matrix[1, 0] * this.matrix[0, 1];
            }
            int flag = 1; //sign + - + - when caculator determinant
            float det = 0;
            for (int i = 0; i < this.N_matrix; i++)
            {
                Matrix_Int subMatrix = this.CopyMatrixExclude(i);
                float sub_det = subMatrix.Determinant();
                det += this.matrix[0,i] * flag * sub_det;
                flag *= -1;
            }
            return det;
        }

        /// <summary>
        /// Copy new matrix form this, exculude column j
        /// </summary>
        /// <param name="j">column</param>
        /// <returns>new Matrix</returns>
        protected Matrix_Int CopyMatrixExclude(int j)
        {
            int n = N_matrix - 1;
            Matrix_Int matrix_new = new Matrix_Int(n);
            int a = 0;
            for (int t = 1; t < N_matrix; t++)
            {
                for (int u = 0; u < N_matrix; u++)
                {
                    if (u == j) continue;//drop column j
                    matrix_new.matrix[a / n, a % n] = this.matrix[t, u];
                    a++;
                }
            }
            return matrix_new;
        }
    }
}
