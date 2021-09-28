using System;

namespace ClassIntro
{
    class Robot
    {
        private int batteryLevel;
        public string Name;
        public string Type;
        public string Color;

        public Robot()
        {
            batteryLevel = 100;
            Name = "Generic Robot";
            Type = "Robot";
            Color = "Silver";
            Console.WriteLine("hello from other robot constructor!");
        }

        public Robot(string name, string type, string color)
        {
            batteryLevel = 100;
            Name = name;
            Type = type;
            Color = color;
            Console.WriteLine("hello from robot constructor!");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"My name is {Name} and I am a {Color} {Type}. Battery Level is {batteryLevel}");
        }

        public void ServeDinner(bool isVegan)
        {
            if(batteryLevel > 30)
            {
                if(isVegan)
                {
                    Console.WriteLine("here is your falafel!");
                }
                else
                {
                    Console.WriteLine("here is your mayo on a plate");
                }

                batteryLevel -= 25;
            }
            else
            {
                Console.WriteLine("battery level is too low!");
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robot Steve = new Robot("Steve", "Chef Robot", "Red");
            Robot VeganSteve = new Robot("Stevegan", "Vegan Chef Robot", "Green");
            Robot Generic = new Robot();

            //THIS LINE WON'T WORK
            // Console.WriteLine(VeganSteve.batteryLevel);
            
            VeganSteve.ServeDinner(true);
            VeganSteve.ServeDinner(true);
            VeganSteve.ServeDinner(true);
            VeganSteve.ServeDinner(true);

            Console.WriteLine("Hello World!");
        }
    }
}
