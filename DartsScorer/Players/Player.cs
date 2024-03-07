namespace DartsScorer.Players;

public class Player
{
    public Player(string name, int startScore)
    {
        Name = name;
        StartScore = startScore;
    }

    public string Name { get; private set; }
    public int StartScore { get; }
}