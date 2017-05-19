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
            Hill a = new Hill(3);

            a.Matrix.SetValueChar(0, 0, 'N');
            a.Matrix.SetValueChar(0, 1, 'H');
            a.Matrix.SetValueChar(0, 2, 'R');
            a.Matrix.SetValueChar(1, 0, 'Q');
            a.Matrix.SetValueChar(1, 1, 'Y');
            a.Matrix.SetValueChar(1, 2, 'F');
            a.Matrix.SetValueChar(2, 0, 'A');
            a.Matrix.SetValueChar(2, 1, 'J');
            a.Matrix.SetValueChar(2, 2, 'D');
            a.SetData("THANH PHO");
            var result = a.Encrypt();
            Assert.AreEqual("KELFJEIRN", result);
        }

        [TestMethod()]
        public void Encrypt_N_Char_Test_3()
        {
            Hill a = new Hill(3);

            a.Matrix.SetValueChar(0, 0, 'N');
            a.Matrix.SetValueChar(0, 1, 'H');
            a.Matrix.SetValueChar(0, 2, 'R');
            a.Matrix.SetValueChar(1, 0, 'Q');
            a.Matrix.SetValueChar(1, 1, 'Y');
            a.Matrix.SetValueChar(1, 2, 'F');
            a.Matrix.SetValueChar(2, 0, 'A');
            a.Matrix.SetValueChar(2, 1, 'J');
            a.Matrix.SetValueChar(2, 2, 'D');
            a.SetData("THA");
            var result = a.Encrypt_N_Char(new char[] { 'T', 'H', 'A' });
            CollectionAssert.AreEqual(new char[] { 'K', 'E', 'L' }, result);
        }

        [TestMethod()]
        public void Encrypt_N_Char_Test_2()
        {
            Hill a = new Hill(2);

            a.Matrix.SetValueChar(0, 0, 'Z');
            a.Matrix.SetValueChar(0, 1, 'F');
            a.Matrix.SetValueChar(1, 0, 'U');
            a.Matrix.SetValueChar(1, 1, 'H');
            a.SetData("Th");
            var result = a.Encrypt_N_Char(new char[] { 'T', 'H' });
            CollectionAssert.AreEqual(new char[] { 'Q', 'N' }, result);
        }
    }
}
