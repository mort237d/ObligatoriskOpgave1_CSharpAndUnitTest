using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1_CSharpAndUnitTest;

namespace TestBog
{
    [TestClass]
    public class UnitTest1
    {
        Bog bog = new Bog();

        [TestMethod]
        public void TestBogTitel()
        {
            Assert.ThrowsException<ArgumentException>(() => bog.Titel = "h");
            string testTitel = "Bogen om Morten";
            bog.Titel = testTitel;
            Assert.AreEqual(testTitel,bog.Titel);
        }

        [TestMethod]
        public void TestBogForfatter()
        {
            string testForfatter = "KageDrengen";
            bog.Forfatter = testForfatter;
            Assert.AreEqual(testForfatter, bog.Forfatter);
        }

        [TestMethod]
        public void TestBogSideTal()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bog.Sidetal = 9);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bog.Sidetal = 1001);
            
            for (int i = 10; i < 1000; i++)
            {
                int testSideTal = i;
                bog.Sidetal = testSideTal;
                Assert.AreEqual(testSideTal, bog.Sidetal);
            }
        }

        [TestMethod]
        public void TestBogISBN13()
        {
            Assert.ThrowsException<ArgumentException>(() => bog.Isbn13 = "h");
            string testIsbn13 = "ISBN123456789";
            bog.Isbn13 = testIsbn13;
            Assert.AreEqual(testIsbn13, bog.Isbn13);
        }

        [TestMethod]
        public void TestBogObjekt()
        {
            Bog bog2 = new Bog("Mortens Bog", "Jasmin", 10, "ISBN123456789");
        }
    }
}
