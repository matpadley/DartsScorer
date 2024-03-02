using Newtonsoft.Json;

namespace DartsScorer.Checkout
{
    public class CheckoutCalculator
    {
        private Dictionary<int, List<string>>? _checkoutData;

        public CheckoutCalculator()
        {
            var json = File.ReadAllText(Path.Combine(Path.Combine("checkout", "checkout.json")));
            _checkoutData = JsonConvert.DeserializeObject<Dictionary<int, List<string>>>(json);
        }

        public string[] CalculateCheckout(int score)
        {
            if (score > 170) throw new ArgumentOutOfRangeException(nameof(score), "Score cannot be greater than 170");
            
            return _checkoutData
                .First(f => f.Key == score)
                .Value
                .ToArray();
        }
    }
}