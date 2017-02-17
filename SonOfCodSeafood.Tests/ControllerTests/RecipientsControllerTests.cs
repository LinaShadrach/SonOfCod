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
    public class RecipientsControllerTests
    {
        [Fact]
        public void Get_ViewResult_Newsletter()
        {
            RecipientsController controller = new RecipientsController();
            var result = controller.Newsletter();

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void GetModelRecipient_Newsletter()
        {
            //Arrange
            ViewResult newsletterView = new RecipientsController().Newsletter() as ViewResult;

            //Act
            var result = newsletterView.ViewData.Model;

            //Assert
            Assert.IsType<Recipient>(result);
        }
    }
}
