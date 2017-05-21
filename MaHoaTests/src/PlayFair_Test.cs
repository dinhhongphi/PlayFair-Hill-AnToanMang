using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaHoa;

namespace MaHoaTests.src
{
    [TestClass]
    public class PlayFair_Test
    {
        [TestMethod]
        public void RemoveSpaceInString_TestValid_Value_Return()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);

            var result = playfair.RemoveSpaceInString("Dinh Hong Phi");
            Assert.AreEqual("DinhHongPhi", result);
        }

        [TestMethod]
        public void HoanDoi_Test_Valid_Value_Return()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("phi");

            //char[,] expect = new char[5, 5]
            //{
            //    {'P','H','I','A','B' },
            //    { 'C','D','E','F','G'},
            //    {'K','L','M','N','O' },
            //    {'Q','R','S','T','U' },
            //    {'V','W','X','Y','Z' }
            //};
            //P and M
            var result1 = playfair.HoanDoi(new Coordinate { I = 0, J = 0 }, new Coordinate { I = 2, J = 2 });
            Assert.AreEqual("IK", result1);
            //P and V
            var result2 = playfair.HoanDoi(new Coordinate { I = 0, J = 0 }, new Coordinate { I = 4, J = 0 });
            Assert.AreEqual("CP", result2);
            //P and B
            var result3 = playfair.HoanDoi(new Coordinate { I = 0, J = 0 }, new Coordinate { I = 0, J = 4 });
            Assert.AreEqual("HP", result3);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void HoanDoi_Test_IndexOutOfRange()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("phi");
            //check index out of range
            var result = playfair.HoanDoi(new Coordinate { I = 2, J = 6 }, new Coordinate { I = 2, J = 2 });
            result = playfair.HoanDoi(new Coordinate { I = 5, J = 2 }, new Coordinate { I = 2, J = 2 });
            result = playfair.HoanDoi(new Coordinate { I = 0, J = 4 }, new Coordinate { I = 2, J = 5 });
            result = playfair.HoanDoi(new Coordinate { I = 0, J = 4 }, new Coordinate { I = 5, J = 2 });
        }

        [TestMethod]
        public void EncryptTwoCharacter_Test_valid_result()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("phi");

            //char[,] expect = new char[5, 5]
            //{
            //    {'P','H','I','A','B' },
            //    { 'C','D','E','F','G'},
            //    {'K','L','M','N','O' },
            //    {'Q','R','S','T','U' },
            //    {'V','W','X','Y','Z' }
            //};
            var result = playfair.EncryptTwoCharacter('h', 'm');
            Assert.AreEqual("IL", result);
            var result2 = playfair.EncryptTwoCharacter('A', 't');
            Assert.AreEqual("FY", result2);
            var result3 = playfair.EncryptTwoCharacter('q', 'R');
            Assert.AreEqual("RS", result3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EncryptTwoCharacter_Test_input_empty()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("phi");
            var result = playfair.EncryptTwoCharacter('A',' ');
        }

        [TestMethod]
        public void Encrypt_Test_plain_text_is_odd_character()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("dai hoc cong nghe thong tin");
            string result = playfair.Encrypt("xin chao cac ban");
            Assert.AreEqual("IGGNOIDTDNFDGW",result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Encrypt_Test_argument_invalid()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("dai hoc cong nghe thong tin");
            string result = playfair.Encrypt("!@#$AVSDD");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "plaintext is empty")]
        public void Encrypt_Test_argument_is_empty()
        {
            MaHoa.PlayFair playfair = new PlayFair(5);
            playfair.InitMatrix("dai hoc cong nghe thong tin");
            string result = playfair.Encrypt("");
        }
    }
}
