// See https://aka.ms/new-console-template for more information

using DartsScorer.Checkout;

var checkout = new CheckoutCalculator();

int inputScore = 0;

if (args.Length == 0)
{
    Console.WriteLine("Please provide a score to calculate checkout");
    Environment.Exit(0);
}

if (!Int32.TryParse(args[0], out inputScore))
{
    Console.WriteLine("Request score is not a valid number");
   Environment.Exit(0);
}

foreach (var s in checkout
             .CalculateCheckout(inputScore)
             .ToArray())
{
    Console.WriteLine(s);
}
