[TestClass]
public class CalculatorViewModelTests
{
    [TestMethod]
    public void Add_ShouldReturnCorrectSum()
    {
        var vm = new CalculatorViewModel
        {
            NumberA = 3,
            NumberB = 5
        };

        vm.Add();

        Assert.AreEqual(8, vm.Result);
    }

    [TestMethod]
    public void Add_WithNegativeNumbers_ShouldReturnCorrectResult()
    {
        var vm = new CalculatorViewModel
        {
            NumberA = -2,
            NumberB = -3
        };

        vm.Add();

        Assert.AreEqual(-5, vm.Result);
    }
}
