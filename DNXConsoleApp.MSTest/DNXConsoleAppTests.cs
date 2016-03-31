using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DNXConsoleApp;

namespace DNXConsoleApp.MSTest
{
    [TestClass]
    public class DNXConsoleAppTests
    {
        public DNXConsoleAppTests() 
        { 
        }

        [TestMethod]
        public void GetMessage_GivenNone_ExpectedDefault()
        {
            var expected = "test me";
            var msgBuilder = new MessageBuilder();
            var result = msgBuilder.GetMessage("test me");
            Assert.AreEqual(expected, result);
        }
    }
}
