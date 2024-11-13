namespace Scorer.Core
{
    public class Player
    {
        public int CurrentScore { get; set; }
        
        public Leg[] Legs { get; set; }
        
        public string Name { get; set; }
    }

    public class Leg
    {
        public Score[] Scores { get; set; }
    }

    public class Score
    {
        public Throw[] Throws { get; set; }
    }

    public class Throw
    {
        public Dart First { get; set; }
        public Dart Second { get; set; }
        public Dart Third { get; set; }
    }

    public class Dart
    {
        public string Type { get; set; } // Double, Single, or Treble
        public int Value { get; set; }
    }
}
