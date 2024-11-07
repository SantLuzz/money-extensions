namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
    
    [TestMethod]
    public void ToFormatedValue_ShouldReturnFormattedCurrency_WhenAmountIsPositive()
    {
        // Arrange
        decimal amount = 1234.56m;
        
        // Act
        string result = amount.ToFormatedValue();
        
        // Assert
        Assert.AreEqual("R$ 1.234,56", result);
    }

    [TestMethod]
    public void ToFormatedValue_ShouldReturnZeroCurrency_WhenAmountIsZero()
    {
        // Arrange
        decimal amount = 0m;
        
        // Act
        string result = amount.ToFormatedValue();
        
        // Assert
        Assert.AreEqual("R$ 0,00", result);
    }

    [TestMethod]
    public void ToFormatedValue_ShouldReturnZeroCurrency_WhenAmountIsNegative()
    {
        // Arrange
        decimal amount = -100m;
        
        // Act
        string result = amount.ToFormatedValue();
        
        // Assert
        Assert.AreEqual("R$ 0,00", result); 
    }
}