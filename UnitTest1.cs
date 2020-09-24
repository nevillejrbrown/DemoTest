using NUnit.Framework;
using demo.Controllers;


namespace DemoTest
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
            Assert.AreEqual(Dummy.DoubleMe(2),4);
        }
    }
}