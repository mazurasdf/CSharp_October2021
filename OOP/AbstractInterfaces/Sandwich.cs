using System;
using System.Collections.Generic;

namespace AbstractInterfaces
{
    public class Sandwich : IRandomizable
    {
        public List<string> Ingredients;
        public string Name;

        public Sandwich(string name)
        {
            Name = name;
            Ingredients = new List<string>();
            Ingredients.Add("bread");
            Ingredients.Add("bread");
        }

        public void AddIngredient(string ingredient)
        {
            Ingredients.Insert(1,ingredient);
        }

        public void PrintSandwich()
        {
            Console.WriteLine("welcome to sadwiches......sigh... here's your order");
            string list = "";

            foreach(string item in Ingredients)
            {
                list += item + ", ";
            }

            Console.WriteLine(list);
        }

        public void Randomize()
        {
            for(int i = 1; i < Ingredients.Count - 1; ++i)
            {
                Random rand = new Random();

                int newIndex = rand.Next(1,Ingredients.Count - 1);

                string temp = Ingredients[i];
                Ingredients[i] = Ingredients[newIndex];
                Ingredients[newIndex] = temp;
            }
        }

        public void RandomSet()
        {
            Random rand = new Random();
            string[] ingredients = {"tomato", "mayo", "grass clippings", "peanut butter", "jelly", "honey", "chocolate sauce", "cheese slice", "meat", "sadness", "maple syrup", "dijon mustard", "mortadella", "capicola", "cucumber slices", "spinach", "fried egg", "vinagrette", "salt", "more bread"};
            int numIngredients = rand.Next(3,7);

            for(int i = 0; i < numIngredients; ++i)
            {
                bool isToasted = false;
                if(rand.Next(0,2) == 1)
                {
                    isToasted = true;
                }
                int randIndex = rand.Next(0, ingredients.Length);
                AddIngredient(isToasted ? "toasted " + ingredients[randIndex] : ingredients[randIndex]);
            }

            Randomize();
        }
    }
}