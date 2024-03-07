using DartsScorer.Checkout;

namespace DartsScorer.Tests;

public class CheckOutCalculatorTests
{
    [TestCase(170, new [] {"T20", "T20", "DB"})]
    public void ReturnsCorrectCheckoutArray(int score, string[] expectedCheckout)
    {
        var checkout = new CheckoutCalculator();

        var result = checkout.CalculateCheckout(score);

        Assert.AreEqual(expectedCheckout, result);
    }
    
    [TestCase]
    public void ThrowsExceptionWhenScoreIsGreaterThan170()
    {
        var checkout = new DartsScorer.Checkout.CheckoutCalculator();

        Assert.Throws<ArgumentOutOfRangeException>(() => checkout.CalculateCheckout(171));
    }
}