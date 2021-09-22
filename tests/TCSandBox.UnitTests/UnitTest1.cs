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
            Assert.Fail("Failed  purposefully");
        }

        [Test]
        public void Test2()
        {
            Assert.Fail("Failed now");
        }
    }
}