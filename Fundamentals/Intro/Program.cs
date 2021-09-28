using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, double, char, string, bool
            int numOfPancakes = 9;
            double pi = 3.14159;
            char first = '9';
            string phrase = "hey it's me, the string!";
            bool isReady = true;

            if(numOfPancakes < 9)
            {
                Console.WriteLine("that's not a lot of pancakes!");
            }
            else if(numOfPancakes != 10)
            {
                Console.WriteLine("that's too many pancakes!");
            }
            else
            {
                Console.WriteLine("that's a lot of pancakes!");
            }

            // int count = 0;
            // while(isReady && count < 100)
            // {
            //     count++;
            // }

            for(int i = 0; i < 100; i++)
            {
                i++;
                Console.WriteLine(i);
            }


            // Console.WriteLine(count);
        }
    }
}
