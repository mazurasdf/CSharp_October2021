using System;
using System.Collections.Generic;

namespace Smash
{
    abstract class Fighter
    {
        private int playerNum;
        public int PlayerNum
        {
            get {return playerNum;}
        }
        private string characterName;
        public string CharacterName
        {
            get {return characterName;}
        }

        private int percentage;
        public int Percentage
        {
            get {return percentage;}
            set {percentage = value;}
        }
        private int weight;
        public int Weight
        {
            get {return weight;}
        }

        public Fighter(int player, string name, int characterWeight)
        {
            Console.WriteLine("hello from fighter constructor");
            playerNum = player;
            characterName = name;
            weight = characterWeight;
            percentage = 0;
        }

        public void Attack(Fighter opponent)
        {
            int damage = 5;

            opponent.percentage += damage;

            Console.WriteLine($"{CharacterName} attacked {opponent.CharacterName} and dealt {damage}%!!!!!");
        }

        public abstract void Special(Fighter opponent);
    }

    class Samus : Fighter
    {
        private bool isCharged;

        public Samus(int player) : base(player, "Samus", 7)
        {
            Console.WriteLine("hello from samus constructor");
            isCharged = false;
        }

        public override void Special(Fighter opponent)
        {
            int damage = 35;

            if(isCharged)
            {
                opponent.Percentage += damage;
                Console.WriteLine($"{CharacterName} shot her laser ball thing at {opponent.CharacterName} and dealt {damage}%!!!!!");
                isCharged = false;
            }
            else
            {
                isCharged = true;
                Console.WriteLine("Samus is charging her arm cannon!");
            }
        }
    }

    class MetalMario : Fighter
    {
        private bool knifeModeOn;
        public MetalMario(int player) : base(player, "Metal Mario", 10)
        {
            knifeModeOn = false;
        }

        public override void Special(Fighter opponent)
        {
            int damage = 18;

            if(knifeModeOn)
            {
                opponent.Percentage += damage;
                Console.WriteLine($"{CharacterName} knifed {opponent.CharacterName} and dealt {damage}%!!!!!");
            }
            else
            {
                knifeModeOn = true;
                Console.WriteLine("Metal Mario has brought out the knives!!! Is that actuasly T-1000???");
            }
        }
    }
}