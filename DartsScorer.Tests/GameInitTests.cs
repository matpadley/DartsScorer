using DartsScorer.Exceptions;
using DartsScorer.models;
using DartsScorer.Players;
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
    public void CanAddOneOrMorePlayers()
    {
        var mocker = new AutoMocker();
        var gameType = mocker.CreateInstance<GameType>();
        var game = new Game(gameType);

        var players = mocker.CreateInstance<List<string>>();

        game.AddPlayers(players);
    }
    
    
    [TestCase]
    public void GameCanStartWithPlayers()
    {
        var mocker = new AutoMocker();
        var gameType = mocker.CreateInstance<GameType>();
        var game = new Game(gameType);

        var players = mocker.CreateInstance<List<String>>();

        game.AddPlayers(players);

        Assert.DoesNotThrow(() => game.Start());
    }
}

public class BaseGameTestSetup
{
    
}