using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaHoa;
namespace MaHoaTests.src
{
    [TestClass]
    public class MatrixPlayFairTest
    {
        [TestMethod]
        public void InitMatrix_Test()
        {
            MatrixPlayFair matrix = new MatrixPlayFair(5);
            matrix.CreateMatrix("PHI");

            char[,] expect = new char[5, 5]
            {
                {'P','H','I','A','B' },
                { 'C','D','E','F','G'},
                {'K','L','M','N','O' },
                {'Q','R','S','T','U' },
                {'V','W','X','Y','Z' }
            };

            CollectionAssert.AreEqual(matrix.matrix, expect);
        }

        [TestMethod]
        public void InitMatrix_6_vector()
        {
            MatrixPlayFair matrix = new MatrixPlayFair(6);
            matrix.CreateMatrix("PHI143");

            char[,] expect = new char[6, 6]
            {
                {'P','H','I','1','4','3'},
                { 'A','B','C','D','E','F'},
                {'G','J','K','L','M','N' },
                {'O','Q','R','S','T','U'},
                {'V','W','X','Y','Z','0'},
                { '2','5','6','7','8','9'}
            };
            CollectionAssert.AreEqual(expect, matrix.matrix);
        }

        [TestMethod]
        public void RemoveSameCharacter_Test()
        {
            MatrixPlayFair matrix = new MatrixPlayFair(5);
            string a = matrix.RemoveSameCharacter("PHIABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.AreEqual("PHIABCDEFGJKLMNOQRSTUVWXYZ", a);

        }

        [TestMethod]
        public void GetCoordinate_Test_valid_result()
        {
            MatrixPlayFair matrix = new MatrixPlayFair(6);
            matrix.CreateMatrix("PHI143");

            //    {'P','H','I','1','4','3'},
            //    { 'A','B','C','D','E','F'},
            //    {'G','J','K','L','M','N' },
            //    {'O','Q','R','S','T','U'},
            //    {'V','W','X','Y','Z','0'},
            //    { '2','5','6','7','8','9'}
            var result = matrix.GetCoordinate('R');
            var c = new Coordinate() { I = 3, J = 2 };
            Assert.AreEqual(c.I, result.I);
            Assert.AreEqual(c.J, result.J);
            result = matrix.GetCoordinate('r');
            Assert.AreEqual(c.I, result.I);
            Assert.AreEqual(c.J, result.J);
        }

        [TestMethod]
        public void GetCoordinate_Test_Charater_dont_exists()
        {
            MatrixPlayFair matrix = new MatrixPlayFair(6);
            matrix.CreateMatrix("PHI143");

            //    {'P','H','I','1','4','3'},
            //    { 'A','B','C','D','E','F'},
            //    {'G','J','K','L','M','N' },
            //    {'O','Q','R','S','T','U'},
            //    {'V','W','X','Y','Z','0'},
            //    { '2','5','6','7','8','9'}
            var result = matrix.GetCoordinate(' ');
            Assert.IsNull(result);
        }
    }
}
