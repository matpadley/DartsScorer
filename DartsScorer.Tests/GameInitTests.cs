using DartsScorer.Exceptions;
using DartsScorer.models;
using FluentAssertions;
using Moq.AutoMock;

namespace DartsScorer.Tests;

public class GameInitTests: BaseGameTestSetup
{
    [TestCase]
    public void GameInitializesCorrectly()
    {
        var mocker = new AutoMocker();
        var gameType = mocker.CreateInstance<GameType>();
        var game = new Game(gameType);
        game.GameType.Should().Be(gameType);
    }

    [TestCase]
    public void GameCannotStartWithNoPlayers()
    {
        var mocker = new AutoMocker();
        var gameType = mocker.CreateInstance<GameType>();
        var game = new Game(gameType);

        Assert.Throws<NoPlayersAddedException>(() => game.Start());
    }

    [TestCase]
    public void ThrowsExpcetionWhenNoPlayersSupplied()
    {
        var mocker = new AutoMocker();
        var gameType = mocker.CreateInstance<GameType>();
        var game = new Game(gameType);
        
        Assert.Throws<NoPlayersAddedException>(() => game.AddPlayers(new List<string>()));
    }
    
    
    [TestCase]
    public void GameCanStartWithPlayers()
    {
        var mocker = new AutoMocker();
        var gameType = mocker.CreateInstance<GameType>();
        var game = new Game(gameType);

        var players = new List<string>()
        {
            "Player One"
        };
        
        game.AddPlayers(players);

        Assert.DoesNotThrow(() => game.Start());
    }
}

public class BaseGameTestSetup
{
    
}