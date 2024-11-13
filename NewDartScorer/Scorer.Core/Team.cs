namespace Scorer.Core
{
    public class Team
    {
        public string Name { get; set; }
        public Player[] Players { get; set; } = new Player[3];

        public Team(string name)
        {
            Name = name;
        }

        public void AddPlayer(Player player)
        {
            if (Players.Length >= 3)
            {
                throw new InvalidOperationException("Cannot add more than 3 players to a team.");
            }

            for (int i = 0; i < Players.Length; i++)
            {
                if (Players[i] == null)
                {
                    Players[i] = player;
                    break;
                }
            }
        }
    }
}
