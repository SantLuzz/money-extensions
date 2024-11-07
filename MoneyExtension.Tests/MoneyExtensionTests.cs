using System.Globalization;

namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    private CultureInfo culture = new CultureInfo("pt-BR");
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
        Assert.AreEqual(amount.ToString("C", culture), result);
    }

    [TestMethod]
    public void ToFormatedValue_ShouldReturnZeroCurrency_WhenAmountIsZero()
    {
        // Arrange
        decimal amount = 0m;
        
        // Act
        string result = amount.ToFormatedValue();
        
        // Assert
        Assert.AreEqual(amount.ToString("C", culture), result);
    }

    [TestMethod]
    public void ToFormatedValue_ShouldReturnZeroCurrency_WhenAmountIsNegative()
    {
        // Arrange
        decimal amount = -100m;
        
        // Act
        string result = amount.ToFormatedValue();
        
        // Assert
        Assert.AreEqual(0.ToString("C", culture), result); 
    }
}