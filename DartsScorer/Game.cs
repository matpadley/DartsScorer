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
        var enumerable = playerNames as string[] ?? playerNames.ToArray();
        
        if (!enumerable.Any())
        {
            throw new NoPlayersAddedException();
        }
        foreach (var playerName in enumerable.ToArray())
        {
            Players.Add(new Player(playerName, GameType.StartScore));
        }
    }
}