using NUnit.Framework;

namespace TCSandBox.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Fail("This test is failed purposefully");
        }
    }
}