﻿#if SHIT
using System;
using DNX.Helpers.Log4Net;
using log4net;
using Moq;
using NUnit.Framework;

namespace Test.DNX.Helpers.Log4Net
{
    [TestFixture]
    public class LogExtensionsTests
    {
        [Test]
        public void DebugFunc_MessageText_DebugNotEnabled_TextNotEvaluated()
        {
            // Arrange
            var textCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(false);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<string> getText = () =>
            {
                textCalled = true;

                return "Some text";
            };

            // Act
            logger.Object.DebugFunc(getText);

            // Assert
            Assert.IsFalse(textCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Never());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Never());
        }

        [Test]
        public void DebugFunc_MessageText_DebugEnabled_TextEvaluated()
        {
            // Arrange
            var textCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(true);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<string> getText = () =>
            {
                textCalled = true;

                return "Some text";
            };

            // Act
            logger.Object.DebugFunc(getText);

            // Assert
            Assert.IsTrue(textCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Once());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Never());
        }

        [Test]
        public void DebugFunc_MessageText_DebugNotEnabled_TextNotEvaluated_AnonymousFunc()
        {
            // Arrange
            var textCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(false);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<int> getNumber = () =>
            {
                textCalled = true;

                return DateTime.UtcNow.Millisecond;
            };

            // Act
            logger.Object.DebugFunc(() => string.Format("Value: {0}", getNumber()));

            // Assert
            Assert.IsFalse(textCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Never());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Never());
        }

        [Test]
        public void DebugFunc_MessageText_DebugEnabled_TextEvaluated_AnonymousFunc()
        {
            // Arrange
            var textCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(true);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<int> getNumber = () =>
            {
                textCalled = true;

                return DateTime.UtcNow.Millisecond;
            };

            // Act
            logger.Object.DebugFunc(() => string.Format("Value: {0}", getNumber()));

            // Assert
            Assert.IsTrue(textCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Once());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Never());
        }

        [Test]
        public void DebugFunc_MessageTextAndException_DebugNotEnabled_TextAndExceptionNotEvaluated()
        {
            // Arrange
            var textCalled = false;
            var exceptionCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(false);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<string> getText = () =>
            {
                textCalled = true;

                return "Some text";
            };

            Func<Exception> getException = () =>
            {
                exceptionCalled = true;

                return new Exception();
            };

            // Act
            logger.Object.DebugFunc(getText, getException);

            // Assert
            Assert.IsFalse(textCalled);
            Assert.IsFalse(exceptionCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Never());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Never());
        }

        [Test]
        public void DebugFunc_MessageTextAndException_DebugEnabled_TextAndExceptionEvaluated()
        {
            // Arrange
            var textCalled = false;
            var exceptionCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(true);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<string> getText = () =>
            {
                textCalled = true;

                return "Some text";
            };

            Func<Exception> getException = () =>
            {
                exceptionCalled = true;

                return new Exception();
            };

            // Act
            logger.Object.DebugFunc(getText, getException);

            // Assert
            Assert.IsTrue(textCalled);
            Assert.IsTrue(exceptionCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Never());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Once());
        }

        [Test]
        public void DebugFunc_MessageTextAndException_DebugNotEnabled_TextAndExceptionNotEvaluated_AnonymousFunc()
        {
            // Arrange
            var textCalled = false;
            var exceptionCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(false);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<int> getNumber = () =>
            {
                textCalled = true;

                return DateTime.UtcNow.Millisecond;
            };

            Func<Exception> getException = () =>
            {
                exceptionCalled = true;

                return new Exception();
            };

            // Act
            logger.Object.DebugFunc(() => string.Format("Value: {0}", getNumber()), () => getException());

            // Assert
            Assert.IsFalse(textCalled);
            Assert.IsFalse(exceptionCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Never());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Never());
        }

        [Test]
        public void DebugFunc_MessageTextAndException_DebugEnabled_TextAndExceptionEvaluated_AnonymousFunc()
        {
            // Arrange
            var textCalled = false;
            var exceptionCalled = false;

            var logger = new Mock<ILog>(MockBehavior.Strict);
            logger.Setup(l => l.IsDebugEnabled).Returns(true);
            logger.Setup(l => l.Debug(It.IsAny<object>()));
            logger.Setup(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()));

            Func<int> getNumber = () =>
            {
                textCalled = true;

                return DateTime.UtcNow.Millisecond;
            };

            Func<Exception> getException = () =>
            {
                exceptionCalled = true;

                return new Exception();
            };

            // Act
            logger.Object.DebugFunc(() => string.Format("Value: {0}", getNumber()), () => getException());

            // Assert
            Assert.IsTrue(textCalled);
            Assert.IsTrue(exceptionCalled);
            logger.Verify(l => l.Debug(It.IsAny<object>()), Times.Never());
            logger.Verify(l => l.Debug(It.IsAny<object>(), It.IsAny<Exception>()), Times.Once());
        }
    }
}
#endif
