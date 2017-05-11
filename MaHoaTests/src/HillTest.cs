using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaHoa;

namespace MaHoaTests.src
{
    [TestClass]
    public class HillTest
    {
        [TestMethod]
        public void Encrypt_Test()
        {
            Hill a = new Hill(3)
            {
                Matrix = new HillKey(3)
                {
                    matrix = new char[3, 3]
                    {
                        {'N','H','R' },
                        {'Q','Y','F' },
                        { 'A','J','D'}
                    },
                    matrix_int = new Matrix_Int(3)
                    {
                        matrix = new int[3, 3]
                        {
                            {13,7,17 },
                            {16,24,5 },
                            {0,9,3 }
                        }
                    }
                }
            };
            a.SetData("THANH PHO");
            var result = a.Encrypt();
            Assert.AreEqual("KELFJEIRN", result);
        }

        [TestMethod()]
        public void Encrypt_N_Char_Test_3()
        {
            Hill a = new Hill(3)
            {
                Matrix = new HillKey(3)
                {
                    matrix = new char[3, 3]
                    {
                        {'N','H','R' },
                        {'Q','Y','F' },
                        { 'A','J','D'}
                    }
                }
            };
            a.SetData("THA");
            var result = a.Encrypt_N_Char(new char[] { 'T', 'H', 'A' });
            CollectionAssert.AreEqual(new char[] { 'K', 'E', 'L' }, result);
        }

        [TestMethod()]
        public void Encrypt_N_Char_Test_2()
        {
            Hill a = new Hill(2)
            {
                Matrix = new HillKey(2)
                {
                    matrix = new char[2, 2]
                    {
                        {'Z','F'},
                        {'U', 'H'}
                    }
                }
            };
            a.SetData("Th");
            var result = a.Encrypt_N_Char(new char[] { 'T', 'H' });
            CollectionAssert.AreEqual(new char[] { 'Q', 'N' }, result);
        }
    }
}
