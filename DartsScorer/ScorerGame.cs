namespace TestProject1.GameInit;

public class ScorerGame
{
    public Guid Id { get; set; }

    public ScorerGame()
    {
        Id = Guid.NewGuid();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public int PlayerCount => 0;
}