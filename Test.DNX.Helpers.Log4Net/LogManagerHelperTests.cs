using DNX.Helpers.Log4Net;
using NUnit.Framework;

namespace Test.DNX.Helpers.Log4Net
{
    internal class MyClass1
    {
    }

    [TestFixture]
    public class LogManagerHelperTests
    {
        [Test]
        public void GetDefaultLogger_Test()
        {
            var logger = LogManagerHelper.GetDefaultLogger();

            Assert.IsNotNull(logger);
            Assert.AreEqual(string.Empty, logger.Logger.Name);
        }

        [Test]
        public void GetLoggerFor_Test()
        {
            var myClass1 = new MyClass1();
            var logger = LogManagerHelper.GetLoggerFor(myClass1);

            Assert.IsNotNull(logger);
            Assert.AreEqual(myClass1.GetType().FullName, logger.Logger.Name);
        }

        [Test]
        public void GetMyLoggerTest()
        {
            var logger = LogManagerHelper.GetMyLogger();

            Assert.IsNotNull(logger);
            Assert.AreEqual(this.GetType().FullName, logger.Logger.Name);
        }

        [Test]
        public void GetLoggerTest()
        {
            var logger = LogManagerHelper.GetLogger<MyClass1>();

            Assert.IsNotNull(logger);
            Assert.AreEqual(typeof(MyClass1).FullName, logger.Logger.Name);
        }
    }
}
