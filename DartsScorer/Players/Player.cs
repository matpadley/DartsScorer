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
    public object Checkout()
    {
        return "";
    }

    public void Throw(int currentThrow, int throwMultiPlier)
    {
        
        CurrentScore = CurrentScore - (currentThrow * throwMultiPlier);
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