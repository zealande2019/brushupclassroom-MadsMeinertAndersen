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
        public void TestVinter�rstid(int m�ned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", m�ned, 1);

            //Act

            string �rstid = studerende.�rstid();

            //Assert

            Assert.AreEqual("Vinter", �rstid);
        }


        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void TestFor�r�rstid(int m�ned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", m�ned, 1);

            //Act

            string �rstid = studerende.�rstid();

            //Assert

            Assert.AreEqual("For�r", �rstid);
        }

        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void TestSommer�rstid(int m�ned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", m�ned, 1);

            //Act

            string �rstid = studerende.�rstid();

            //Assert

            Assert.AreEqual("Sommer", �rstid);
        }

        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void TestEfter�r�rstid(int m�ned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", m�ned, 1);

            //Act

            string �rstid = studerende.�rstid();

            //Assert

            Assert.AreEqual("Efter�r", �rstid);



        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(13)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestForkert�rstid(int m�ned)
        {
            //Arrange

            Studerende studerende = new Studerende("test1", m�ned, 1);

            //Act

            string �rstid = studerende.�rstid();

            //Assert

            Assert.Fail();
        }
    }
}
