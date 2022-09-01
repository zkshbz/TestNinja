using System;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        public ErrorLogger _errorLogger;
        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }
        [Test]
        public void Log_WhenCalled_SetErrorLoggerLastError()
        {
            _errorLogger.Log("a");

            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string testCase)
        {
            Assert.That(() => _errorLogger.Log(testCase), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_InvokeLoggerEvent()
        {
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, args) => { id = args; };
            
            _errorLogger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}