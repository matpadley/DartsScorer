using DartsScorer.Exceptions;

namespace DartsScorer.Players;

public class Player
{
    public Player(string name, int startScore)
    {
        Name = name;
        StartScore = startScore;
        CurrentScore = startScore;
    }

    public int CurrentScore { get; set; }

    public string Name { get; private set; }
    public int StartScore { get; }
    public bool InTurn { get; private set; }
    public int DartsThrown { get; private set; }

    public void Throw(int currentThrow, int throwMultiPlier)
    {
        InTurn = false;
        DartsThrown++;
        CurrentScore -= (currentThrow * throwMultiPlier);
        InTurn = DartsThrown == 1 || DartsThrown == 2;
    }

    public string[] AvailableCheckout()
    {
        
        if (CurrentScore > 170)
        {
            throw new NoCheckOutAvailableException();
        }

        return new string[] { };
    }
}