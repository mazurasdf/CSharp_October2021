using System;
using System.Collections.Generic;

namespace MoreIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS SYNTAX
            // string[] faveIceCreams = new string[5];
            // faveIceCreams[0] = "pistachio";
            // string[] faveIceCreams = {"pistachio", "cookie dough", "americone dream", "moose tracks", "buckeye"};

            // for(int i = 0; i < faveIceCreams.Length; i++)
            // {
            //     Console.WriteLine(faveIceCreams[i]);
            // }

            //LIST
            // List<string> faveIceCreams = new List<string>();
            // faveIceCreams.Add("pistachio");
            // faveIceCreams.Add("strawberry chocolate chunk");
            // faveIceCreams.Add("vanilla");
            // faveIceCreams.Add("chocolate");
            // faveIceCreams.Remove("vanilla");
            // faveIceCreams.RemoveAt(faveIceCreams.Count - 1);
            // for(int i = 0; i < faveIceCreams.Count; i++)
            // {
            //     Console.WriteLine(faveIceCreams[i]);
            // }
            // foreach(string singleIceCream in faveIceCreams)
            // {
            //     Console.WriteLine(singleIceCream);
            // }

            //DICTIONARIES
            // Dictionary<string, string> sundae = new Dictionary<string, string>();
            // sundae.Add("flavor", "vanilla");
            // sundae.Add("sauce", "hot fudge");
            // sundae.Add("topping", "rainbow spranks");
            // sundae.Add("nut", "pecans");

            // Console.WriteLine(sundae["topping"]);
            // foreach(KeyValuePair<string,string> ingredient in sundae)
            // {
            //     Console.WriteLine($"this sundae has a {ingredient.Key} of {ingredient.Value}!");
            // }

            //TYPE CASTING
            // int faveNum = 23;
            // double specialFaveNum = faveNum;
            // specialFaveNum += 0.2;
            // Console.WriteLine(specialFaveNum);

            // double faveNum = 23.9;
            // int simpleFaveNum = (int)faveNum;
            // Console.WriteLine(simpleFaveNum);

            // int division = 10/3;
            // double otherDivision = division;
            // Console.WriteLine(otherDivision);

            // string bestNum = "23";
            // int otherBestNum = Int32.Parse(bestNum);


            // Console.WriteLine(otherBestNum);
            Console.WriteLine(PrintMany("hey it's me!", 5));

            //THIS WON'T WORK
            // int otherInt = PrintMany("hey it's me!", 5);
        }

        public static string PrintMany(string phrase, int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine(phrase);
            }

            return "the function is over!";
        }
    }
}
