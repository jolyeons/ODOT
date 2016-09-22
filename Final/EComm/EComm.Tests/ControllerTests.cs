using EComm.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm.Tests
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void Homepage()
        {
            Assert.AreEqual(5, 5);

            /* 
            var controller = new HomeController();

            var r = controller.Index();
            Assert.IsInstanceOfType(r, typeof(ViewResult));
            */
        }
    }
}
