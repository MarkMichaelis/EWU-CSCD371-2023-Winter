namespace Calculate.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Create_RedirectStandardIO_Success()
    {
        string? output = null;
        Calculator calculator = new Calculator(
            text => output = text,
            () => "1 + 1");
        Assert.IsTrue(calculator.TryCalculate("1 + 1", out int actual));
        Assert.AreEqual(2, actual);
    }
}