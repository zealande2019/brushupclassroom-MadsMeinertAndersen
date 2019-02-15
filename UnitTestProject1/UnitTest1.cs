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
        public void ÅrstidMetode(int value)
        {
            //Arrange
            Studerende studerende = new Studerende("test1", value, 1);

            //Act

            string årstid = studerende.Årstid();

            //Assert

            Assert.AreEqual("Vinter", studerende.Årstid());

        }
    }
}
