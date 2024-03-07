using DartsScorer.Exceptions;
using DartsScorer.Players;
using FluentAssertions;

namespace DartsScorer.Tests;

public class PlayerTests
{
    [TestCase]
    public void PlayerIsInitialisedWithName()
    {
        var name = "player name";
        var startScore = 501;

        var player = new Player(name, startScore);

        player.Name.Should().Be(name);
        player.StartScore.Should().Be(startScore);
    }

    [TestCase]
    public void PlayerScoreShouldBeCorrectAfterThrow()
    {
        var name = "player name";
        var startScore = 501;

        var currentThrow = 12;
        var throwMultiplier = 2;
        
        var player = new Player(name, startScore);

        player.Throw(currentThrow, throwMultiplier);

        player.CurrentScore.Should().Be(startScore - (currentThrow * throwMultiplier));
    }

    [TestCase]
    public void ThrowsNoCheckOutExceptionWhenNoCheckoutAvailable()
    {
        var name = "player name";
        var startScore = 501;

        var currentThrow = 12;
        var throwMultiPlier = 2;
        
        var player = new Player(name, startScore);

        player.Throw(currentThrow, throwMultiPlier);

        Assert.Throws<NoCheckOutAvailableException>(() => player.AvailableCheckout());
    }
}