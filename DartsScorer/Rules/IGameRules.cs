using DartsScorer.models;

namespace DartsScorer.Rules;

public interface IGameRules
{
    public IEnumerator<GameType> GameTypes { get; }
}