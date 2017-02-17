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
        public void GetModelRecipient_Newsletter_Signup()
        {
            //Arrange
            Recipient recipient = new Recipient(0, "Lila", "lila@mai.com", 99654, 0);
            List<Fish> fish = new List<Fish>() { new Fish("halibut"), new Fish("salmon")};
            ViewResult signUpView = new RecipientsController().SignUp(recipient, fish) as ViewResult;

            //Act
            var result = signUpView.ViewData.Model;

            //Assert
            Assert.IsType<Recipient>(result);
        }
    }
}
