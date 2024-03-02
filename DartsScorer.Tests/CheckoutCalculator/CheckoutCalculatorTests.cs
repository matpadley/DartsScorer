using DartsScorer.Checkout;

namespace TestProject1.CheckoutCalculator;

public class Tests
{
    [TestCase(170, new [] {"T20", "T20", "DB"})]
    public void ReturnsCorrectCheckoutArray(int score, string[] expectedCheckout)
    {
        var checkout = new Calculator();

        var result = checkout.CalculateCheckout(score);

        Assert.AreEqual(expectedCheckout, result);
    }
    
    [TestCase]
    public void ThrowsExceptionWhenScoreIsGreaterThan170()
    {
        var checkout = new Calculator();

        Assert.Throws<ArgumentOutOfRangeException>(() => checkout.CalculateCheckout(171));
    }
}