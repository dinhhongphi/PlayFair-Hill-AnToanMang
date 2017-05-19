using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MaHoa
{
    public class Matrix_Int
    {
#if TEST
        public int[,] matrix;
        public int[,] matrix_inverse;
        public int N_matrix; //size of matrix
#else
        protected int[,] matrix;
        public int[,] matrix_inverse;
        public int N_matrix; //size of matrix
#endif
        public Matrix_Int(int n)
        {
            N_matrix = n;
            matrix = new int[N_matrix, N_matrix];
            matrix_inverse = new int[N_matrix, N_matrix];
        }

        public int Get(int i, int j)
        {
            return matrix[i, j];
        }

        public int Get(Coordinate cor)
        {
            return matrix[cor.I, cor.J];
        }

        public void Set(int i, int j, int value)
        {
            matrix[i, j] = value;
        }

        /// <summary>
        /// create Inverse matrix from this
        /// </summary>
        public void InverseMatrix()
        {
            var adj_A = this.Adjugate();
            if (this.Determinant() == 0) throw new Exception("detA != 0");
            var det_inverse = this.Multiplicative_Inverse();
            if(det_inverse < 0)
            {
                det_inverse = (det_inverse + (((Math.Abs(det_inverse) / 26) + 1) * 26));
            }
            for(int i = 0; i < N_matrix; i++)
            {
                for(int j = 0; j < N_matrix; j++)
                {
                    this.matrix_inverse[i, j] = (adj_A.matrix[i, j] * det_inverse) % 26;
                }
            }
        }
        /// <summary>
        /// caculator determinant of matrix
        /// </summary>
        /// <returns></returns>
        public int Determinant()
        {
            if (this.N_matrix == 1)
            {
                return this.matrix[0, 0];
            }
            if (this.N_matrix == 2)
            {
                return this.matrix[0, 0] * this.matrix[1, 1] - this.matrix[1, 0] * this.matrix[0, 1];
            }
            int flag = 1; //sign + - + - when caculator determinant
            int det = 0;
            for (int i = 0; i < this.N_matrix; i++)
            {
                Matrix_Int subMatrix = this.CopyMatrixExclude(0, i);
                int sub_det = subMatrix.Determinant();
                det += this.matrix[0, i] * flag * sub_det;
                flag *= -1;
            }
            return det;
        }
        /// <summary>
        /// Copy new matrix form this, exculude column j row i
        /// </summary>
        /// /// <param name="i">row</param>
        /// <param name="j">column</param>
        /// <returns>new Matrix</returns>
#if TEST
        public Matrix_Int CopyMatrixExclude(int i, int j)
#else
        protected Matrix_Int CopyMatrixExclude(int i, int j)
#endif
        {
            int n = N_matrix - 1;
            Matrix_Int matrix_new = new Matrix_Int(n);
            int a = 0;
            for (int t = 0; t < N_matrix; t++)
            {
                if (t == i) continue;//drop row i
                for (int u = 0; u < N_matrix; u++)
                {
                    if (u == j) continue;//drop column j
                    matrix_new.matrix[a / n, a % n] = this.matrix[t, u];
                    a++;
                }
            }
            return matrix_new;
        }

        /// <summary>
        /// create matrix chuyen vi from this
        /// </summary>
        /// <returns>new Matrix chuyen vi</returns>
        public Matrix_Int Create_Matrix_Chuyen_Vi()
        {
            Matrix_Int new_matrix = new Matrix_Int(N_matrix);
            for (int i = 0; i < N_matrix; i++)
            {
                for (int j = i; j < N_matrix; j++)
                {
                    new_matrix.matrix[i, j] = this.matrix[j, i];
                    new_matrix.matrix[j, i] = this.matrix[i, j];
                }
            }
            return new_matrix;
        }

        /// <summary>
        /// Caculator (d)^(-1).
        /// d*(d)^(-1) = 1 module 26
        /// </summary>
        /// <returns>x</returns>
        public int Multiplicative_Inverse()
        {
            int detA = this.Determinant();
            if (detA < 0) detA = (detA + (((Math.Abs(detA) / 26) + 1) * 26)) % 26;

            //euclid 
            int a = detA, b = 26, x0 = 1, x1 = 0, y0 = 0, y1 = 1;
            int x = 0, y = 0;

            while (b > 0)
            {
                int r = a % b;
                if (r == 0) break;
                int q = a / b;
                x = x0 - x1 * q;
                y = y0 - y1 * q;
                a = b;
                b = r;
                x0 = x1;
                x1 = x;
                y0 = y1;
                y1 = y;
            }
            return x;
        }

        /// <summary>
        /// Tinh ma tran phu hop from this
        /// </summary>
        /// <returns>Matrix phu hop</returns>
        public Matrix_Int Adjugate()
        {
            if (this.N_matrix == 1)
            {
                return new Matrix_Int(1)
                {
                    matrix = new int[1, 1]
                    {
                        {1}
                    }
                };
            }
            Matrix_Int return_matrix = new Matrix_Int(N_matrix);
            int flag_i = 1;
            for (int i = 0; i < N_matrix; i++)
            {
                int flag_j = 1;
                for (int j = 0; j < N_matrix; j++)
                {
                    Matrix_Int copy_matrix = this.CopyMatrixExclude(i, j);
                    var x = flag_i * flag_j * copy_matrix.Determinant();
                    if (x < 0) 
                    {
                        x = (x + (((Math.Abs(x) / 26) + 1) * 26));
                    }
                    //x in [0,26]
                    return_matrix.matrix[j, i] = x % 26;
                    flag_j *= -1;
                }
                flag_i *= -1;
            }
            return return_matrix;
        }

        public int GetInverse(int i, int j)
        {
            return matrix_inverse[i, j];
        }
    }
}
