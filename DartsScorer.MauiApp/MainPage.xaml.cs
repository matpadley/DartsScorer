using System;
using Microsoft.Maui.Controls;
using DartsScorer.Checkout;

namespace DartsScorer.MauiApp
{
    public partial class MainPage : ContentPage
    {
        private readonly CheckoutCalculator _checkoutCalculator;

        public MainPage()
        {
            InitializeComponent();
            _checkoutCalculator = new CheckoutCalculator();
        }

        private void OnCalculateCheckoutClicked(object sender, EventArgs e)
        {
            if (int.TryParse(ScoreEntry.Text, out int score))
            {
                try
                {
                    var checkoutValues = _checkoutCalculator.CalculateCheckout(score);
                    CheckoutLabel.Text = string.Join(", ", checkoutValues);
                }
                catch (ArgumentOutOfRangeException)
                {
                    CheckoutLabel.Text = "No checkout";
                }
            }
            else
            {
                CheckoutLabel.Text = "Invalid score";
            }
        }
    }
}
