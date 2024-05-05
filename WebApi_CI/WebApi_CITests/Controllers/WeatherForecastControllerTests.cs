using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_CI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Results;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace WebApi_CI.Controllers.Tests
{
    [TestClass()]
    public class WeatherForecastControllerTests
    {
        //[TestMethod()]
        //public void WeatherForecastControllerTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void GetTest()
        {
          


            //Act
            var controller = new WeatherForecastController();
            IActionResult result = controller.Get();


            // Assert
            // var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsNotNull(result);
           // Assert.IsAssignableFrom<IStatusCodeActionResult>(result);
            Assert.AreEqual(200, (result as IStatusCodeActionResult).StatusCode);

        }
    }
}