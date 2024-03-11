using DartsScorer.Checkout;

namespace DartsScorer.Tests.Checkout;

public class CheckOutCalculatorTests
{
    [TestCase(170, new [] {"T20", "T20", "DB"})]
    public void ReturnsCorrectCheckoutArray(int score, string[] expectedCheckout)
    {
        var checkout = new CheckoutCalculator();

        var result = checkout.CalculateCheckout(score);

        Assert.That(result, Is.EqualTo(expectedCheckout));
    }
    
    [TestCase]
    public void ThrowsExceptionWhenScoreIsGreaterThan170()
    {
        var checkout = new CheckoutCalculator();

        Assert.Throws<ArgumentOutOfRangeException>(() => checkout.CalculateCheckout(171));
    }
}