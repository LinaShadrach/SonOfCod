using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCodSeafood.Tests.ControllerTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Get_ViewResult_Index()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
