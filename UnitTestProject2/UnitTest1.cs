using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void TestVinterÅrstid(int måned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", måned, 1);

            //Act

            string årstid = studerende.Årstid();

            //Assert

            Assert.AreEqual("Vinter", årstid);
        }


        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void TestForårÅrstid(int måned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", måned, 1);

            //Act

            string årstid = studerende.Årstid();

            //Assert

            Assert.AreEqual("Forår", årstid);
        }

        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void TestSommerÅrstid(int måned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", måned, 1);

            //Act

            string årstid = studerende.Årstid();

            //Assert

            Assert.AreEqual("Sommer", årstid);
        }

        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void TestEfterårÅrstid(int måned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", måned, 1);

            //Act

            string årstid = studerende.Årstid();

            //Assert

            Assert.AreEqual("Efterår", årstid);



        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(13)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestForkertÅrstid(int måned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", måned, 1);

            //Act

            string årstid = studerende.Årstid();

            //Assert

            Assert.Fail();
        }
    }
}
