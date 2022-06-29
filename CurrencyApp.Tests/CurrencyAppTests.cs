using CurrencyApp.Controllers;
using CurrencyApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyApp.Tests
{
    [TestClass]
    public class CurrencyAppTests
    {
        [TestMethod]
        public void GetAllCurrenciesSuccess()
        {
            var controller = new CurrencyController();
            var response = controller.GetAll();
            var result = response as OkObjectResult;
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
        }

        [TestMethod]
        public void GetAllCurrenciesNotFound()
        {
            var controller = new CurrencyController();
            CurrencyData.Currencies.Clear();
            IActionResult actionResult = controller.GetAll();

            Assert.IsInstanceOfType(actionResult, typeof(NotFoundObjectResult));
        }

        [DataTestMethod]
        [DataRow("Japan")]
        [DataRow("japan")]
        [DataRow("United States")]
        [DataRow("UNITED STATES")]
        [DataRow("united states")]
        public void GetCurrencySuccess(string input)
        {
            var controller = new CurrencyController();
            var response = controller.Get(input);
            var result = response as OkObjectResult;
            Assert.IsNotNull(response);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
        }

        [DataTestMethod]
        [DataRow("Bangladesh")]
        [DataRow("Zimbabwe")]
        public void GetCurrencyNotFound(string input)
        {
            var controller = new CurrencyController();
            IActionResult actionResult = controller.Get(input);

            Assert.IsInstanceOfType(actionResult, typeof(NotFoundObjectResult));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void GetCurrencyBadRequest(string input)
        {
            var controller = new CurrencyController();
            IActionResult actionResult = controller.Get(input);

            Assert.IsInstanceOfType(actionResult, typeof(BadRequestObjectResult));
        }
    }
}
