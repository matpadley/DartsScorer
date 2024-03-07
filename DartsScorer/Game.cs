using DartsScorer.Exceptions;
using DartsScorer.models;
using DartsScorer.Players;

namespace DartsScorer;

public class Game
{
    public readonly GameType GameType;

    public ICollection<Player> Players { get; private set; } = new List<Player>();
    
    public Game(GameType gameType)
    {
        GameType = gameType;
    }

    public void Start()
    {
        if (!Players.Any())
        {
            throw new NoPlayersAddedException();
        }
    }

    public void AddPlayers(IEnumerable<string> playerNames)
    {
        foreach (var playerName in playerNames.ToArray())
        {
            Players.Add(new Player(playerName, GameType.StartScore));
        }
    }
}