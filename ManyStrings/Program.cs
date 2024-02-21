using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4

            Console.WriteLine("Hello, World!");

            string s1 = "Linha \n nova.";
            string s2 = "Tab \t .";
            string s3 = "Uma estrela \u2605";
            string s4 = "Um amongus \u0D9E";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

        }
    }
}
