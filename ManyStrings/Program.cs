using System;
using System.Data.SqlTypes;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4

            string s1 = "Linha \n nova.";
            string s2 = "Tab \t .";
            string s3 = "Uma estrela \u2605";
            string s4 = "Um amongus \u0D9E";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            //Exercise 5

            sbyte bite = 18;
            sbyte x = 3;
            sbyte y = 2;
            string add = $"{x} plus {y} is {x + y}.";
            string whatbite = $"I can bite you {bite + 5} times.";
            string concatenated = "u" + x + 10;
            string concatenated2 = "This many bites: " + bite;

            Console.WriteLine(add);
            Console.WriteLine(whatbite);
            Console.WriteLine(concatenated);
            Console.WriteLine(concatenated2);

        }
    }
}
