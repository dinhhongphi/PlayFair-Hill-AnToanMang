
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaHoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa.Tests
{
    [TestClass()]
    public class Matrix_IntTests
    {
        Matrix_Int matrix;
        [TestInitialize()]
        public void Init()
        {
            matrix = new Matrix_Int(3)
            {
                matrix = new int[3, 3] {
                    {9, 6, 17},
                    {23, 1, 16 },
                    {19, 24, 4 }
                }

                //matrix inverse
                //{
                //    { 14, 2, 17},
                //    { 16, 9 ,13},
                //    { 13, 8, 17}
                //}
            };
        }
        [TestMethod()]
        public void Define_size_n_matrix_after_CopyMatrixExclude_Test()
        {
            var new_matrix = matrix.CopyMatrixExclude(1, 1);
            Assert.AreEqual(new_matrix.N_matrix, 2);
        }
        [TestMethod()]
        public void CopyMatrixExclude_Test()
        {
            var new_matrix = matrix.CopyMatrixExclude(1, 1);
            var expect_matrix = new int[2, 2] {
                    {9, 17},
                    {19, 4}
                };
            CollectionAssert.AreEqual(expect_matrix, new_matrix.matrix);
        }
        [TestMethod()]
        public void Caculator_Determinant_Test()
        {
            var det = matrix.Determinant();
            Assert.AreEqual<float>(6913, det);
        }

        [TestMethod()]
        public void Validate_Create_Matrix_Chuyen_vi()
        {
            var matrix_return = matrix.Create_Matrix_Chuyen_Vi();
            int[,] matrix_expect = new int[3, 3] {
                {9, 23, 19},
                {6, 1, 24},
                {17, 16, 4}
            };
            CollectionAssert.AreEqual(matrix_expect, matrix_return.matrix);
        }

        [TestMethod()]
        public void Validate_Multiplicative_Inverse()
        {
            var value = matrix.Multiplicative_Inverse();
            Assert.AreEqual(-9, value);
        }

        [TestMethod()]
        public void Validate_Deteminate_Matrix_1_size()
        {
            //Test Caculator det(matrix) if n_matrix = 1
            Matrix_Int a = new Matrix_Int(1);
            a.matrix[0, 0] = 1;
            var x = a.Determinant();
            Assert.AreEqual(1, x);
        }

        [TestMethod()]
        public void Validate_Adj_Matrix_1_size()
        {
            //Test Caculator Adj(matrix) if n_matrix = 1
            Matrix_Int a = new Matrix_Int(1);
            a.matrix[0, 0] = 10;
            var x = a.Adjugate();
            var new_matrix = new int[1, 1]
            {
                {1}
            };
            CollectionAssert.AreEqual(new_matrix, x.matrix);
        }

        [TestMethod()]
        public void Validate_Adj_Matrix()
        {
            var x = matrix.Adjugate();
            var new_matrix = new int[3, 3]
            {
                {10,20,1},
                {4,25,13},
                {13,2,1}
            };
            CollectionAssert.AreEqual(new_matrix, x.matrix);
        }

        [TestMethod()]
        public void Validate_Matrix_Inverse()
        {
            matrix.InverseMatrix();
            var new_matrix = new int[3, 3]
            {
                { 14, 2, 17},
                { 16, 9 ,13},
                { 13, 8, 17}
            };
            CollectionAssert.AreEqual(new_matrix, matrix.matrix_inverse);
        }
    }
}