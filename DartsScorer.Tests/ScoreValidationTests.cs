using FluentValidation;

namespace DartsScorer.Tests;

public class ScoreValidationTests
{
    [TestCase]
    public void ValidationTests()
    {
        var validator = new ThrowValidator();
    }
}

public class ThrowValidator: AbstractValidator<DartThrow>
{
    public ThrowValidator()
    {
        RuleFor(c => c.Score).Must(f => f > 0);
        RuleFor(c => c.Score).Must(f => f == 50).When(t => t.Multiplier == 1);
        RuleFor(c => c.Score).Must(f => f == 25).When(t => t.Multiplier == 1);
        RuleFor(c => c.Score).Must(f => f >= 1 && f <= 20).When(t => t.Multiplier >= 1 && t.Multiplier <= 3);
    }
}

public class DartThrow
{
    public int Score { get; set; }
    public int Multiplier { get; set; }
}