using System;

namespace AbstractInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deck customDeck = new Deck();
            // customDeck.Randomize();
            // customDeck.PrintDeck();

            // Sandwich pbj = new Sandwich("peanut butter and jam +");
            // pbj.AddIngredient("peanut butter");
            // pbj.AddIngredient("jam");
            // pbj.AddIngredient("bacon");
            // pbj.AddIngredient("tomato");
            // pbj.AddIngredient("lettuce");
            // pbj.AddIngredient("grilled onion");
            // pbj.AddIngredient("chocolate sauce");
            // pbj.AddIngredient("shoe");
            // pbj.AddIngredient("grass clippings");
            // pbj.AddIngredient("mayo");
            // pbj.AddIngredient("burnt ends");
            // pbj.Randomize();
            // pbj.PrintSandwich();

            // Deck customDeck = new Deck();
            // customDeck.RandomSet();
            // customDeck.PrintDeck();

            Sandwich rando = new Sandwich("Just a total mess");
            rando.RandomSet();
            rando.PrintSandwich();
        }
    }
}
