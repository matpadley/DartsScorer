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
    
    // AddScore
    // {int number, int multiplier}
}