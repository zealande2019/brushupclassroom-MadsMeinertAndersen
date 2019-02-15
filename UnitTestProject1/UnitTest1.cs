using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void �rstidMetode(int value)
        {
            //Arrange
            Studerende studerende = new Studerende("test1", value, 1);

            //Act

            string �rstid = studerende.�rstid();

            //Assert

            Assert.AreEqual("Vinter", studerende.�rstid());

        }
    }
}
