using System;
using NUnit.Framework;

namespace TestProject1.GameInit;
using FluentAssertions;

public class DartsGame
{
    [TestCase]
    public void GameInitializesCorrectly()
    {
        var game = new ScorerGame();
        
        game.Id.Should().NotBeEmpty();
        game.Id.Should().NotBe(Guid.Empty);
    }
    
    [TestCase]
    public void GameThrowsExceptionOnStartWithNoPlayers()
    {
        var game = new ScorerGame();

        game.Start();
        
        //game
    }   
    
    [TestCase]
    public void GameReturnsZeroCountForNolayers()
    {
        var game = new ScorerGame();
        
        var playerCount = game.PlayerCount;

        playerCount.Should().Be(0);
    }
}