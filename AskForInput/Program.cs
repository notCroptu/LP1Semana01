using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um número inteiro.");
            int numint = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza um número real.");
            float numfloat = float.Parse(Console.ReadLine());

            Console.WriteLine($"A soma de {numint} e {numfloat} é {numint + numfloat}.");
        }
    }
}
