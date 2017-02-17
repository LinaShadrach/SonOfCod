using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Controllers;
using SonOfCodSeafood.Models;
using SonOfCodSeafood.ViewModels;
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
        //[Fact]
        //public void Get_ViewResult_Subscribe()
        //{
        //    //Arrange
        //    Recipient recipient = new Recipient("Lila", "99654");
        //    int[] fishIds = new int[] { 1, 2 };
        //    RegisterViewModel registerViewModel = new RegisterViewModel();

        //    Task<IActionResult> signUpView = new RecipientsController().Subscribe(registerViewModel, recipient.Name, recipient.ZipCode, fishIds);

        //    //Act
        //    var result = signUpView.Result;

        //    //Assert
        //    Assert.IsType<Task<IActionResult>>(result);
        //}
    }
}
