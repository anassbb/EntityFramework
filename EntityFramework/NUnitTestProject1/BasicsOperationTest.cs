using MathOperation;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class BasicsOperationTest
    {
        [SetUp]
        public void Setup()
        { 


        }

        [Test]
        public void AddTest()
        {
            BasicsOperation bo = new BasicsOperation(); // Arrange

            int result = bo.Add(2, 5); // Act

            Assert.AreEqual(7, result);
        }

        [Test]
        public void SubTest()
        {

            BasicsOperation bo = new BasicsOperation(); // Arrange

            int result = bo.sub(2, 5); // Act

            Assert.AreEqual(-3, result);
        }
    }
}