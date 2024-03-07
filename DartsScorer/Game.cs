using DartsScorer.Exceptions;
using DartsScorer.models;
using DartsScorer.Players;

namespace DartsScorer;

public class Game
{
    public readonly GameType GameType;

    private IEnumerable<Player> _players = Enumerable.Empty<Player>();
    
    public Game(GameType gameType)
    {
        GameType = gameType;
    }

    public void Start()
    {
        if (!_players.Any())
        {
            throw new NoPlayersAddedException();
        }
    }

    public void AddPlayers(IEnumerable<Player> players)
    {
        _players = players;
    }
}