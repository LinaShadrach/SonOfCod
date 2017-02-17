using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Controllers;
using SonOfCodSeafood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCodSeafood.Tests.ControllerTests
{
    public class AdminControllerTests
    {
        [Fact]
        public void Get_ViewResult_MailingList()
        {
            AdminController controller = new AdminController();
            var result = controller.Newsletter();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void GetModelListRecipient_Newsletter()
        {
            //Arrange
            ViewResult newsletterView = new AdminController().Newsletter() as ViewResult;

            //Act
            var result = newsletterView.ViewData.Model;

            //Assert
            Assert.IsType<List<Recipient>>(result);
        }
    }
}
