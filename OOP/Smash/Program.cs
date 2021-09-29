using System;

namespace Smash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Samus samus = new Samus(1);
            // Fighter slippy = new Fighter(2, "Slippy Toad", 5);

            // slippy.Attack(samus);
            // slippy.Attack(samus);
            // samus.Special(slippy);
            // slippy.Attack(samus);
            // samus.Special(slippy);


            // Console.WriteLine(samus.CharacterName);
            // Console.WriteLine(slippy.Percentage);
            // Console.WriteLine(samus.PlayerNum);
            // Console.WriteLine(samus.Weight);

            Samus samus = new Samus(1);
            MetalMario mm = new MetalMario(2);

            samus.Special(mm);

            mm.Special(samus);

            samus.Attack(mm);

            mm.Special(samus);
            
            mm.Special(samus);
            mm.Special(samus);
        }
    }
}
