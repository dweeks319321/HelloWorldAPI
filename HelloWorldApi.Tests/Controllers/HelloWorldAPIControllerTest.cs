using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApi.Controllers;

namespace HelloWorldApi.Tests.Controllers
{
    [TestClass]
    public class HelloWorldAPIControllerTest
    {
        HelloWorldAPIController testee = new HelloWorldAPIController();

        [TestMethod]
        public void GetReturnTextTest()
        {
            Assert.AreEqual("Hello World", testee.GetReturnText());
        }
    }
}
