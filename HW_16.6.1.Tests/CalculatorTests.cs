namespace HW_16._6._1.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Additional(11, 9) == 20);
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.AreEqual(4, calculator.Subtraction(11, 7));
    }

    [Test]
    public void Miltiplication_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.True(calculator.Miltiplication(8, 9) == 72);
    }

    [Test]
    public void Division_MustReturnNotNull()
    {
        var calculator = new Calculator();
        Assert.NotNull(calculator.Division(10, 2));
    }
}