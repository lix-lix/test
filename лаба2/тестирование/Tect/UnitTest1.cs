using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using тестирование;

namespace Tect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_3()
        {
            string input = "мир";
            string expected = "м";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_Nichego()
        {
            string input = " ";
            string expected = "Ошибка!";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_pi()
        {
            string input = "пи";
            string expected = "Ошибка!";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_vmp()
        {
            string input = "vmp";
            string expected = "q";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_3_wordls()
        {
            string input = "Vmp try pol";
            string expected = "fun";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_5_wordls()
        {
            string input = "Vmp,fox,dog,sea,son";
            string expected = "fohhp";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_3f_wordls()
        {
            string input = "Vmp, False, try.";
            string expected = "Ошибка!";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1_2rus_wordls()
        {
            string input = "Мир май";
            string expected = "бз";
            string actual = Three_words.NewMethod(input);
            Assert.AreEqual(expected, actual);
        }
       
    }

}
