using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorViewModelTests
    {
        [TestMethod]
        public void Add_ShouldAddTwoNumbersCorrectly()
        {
            // Arrange
            var viewModel = new CalculatorViewModel
            {
                NumberA = 5,
                NumberB = 3
            };

            // Act
            viewModel.Add();

            // Assert
            Assert.AreEqual(8, viewModel.Result);
        }
    }
}
