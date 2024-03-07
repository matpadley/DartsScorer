using DartsScorer.models;

namespace DartsScorer.Tests;

public interface IGameRules
{
    public IEnumerator<GameType> GameTypes { get; }
}