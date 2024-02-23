using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduza o primeiro número real.");
            float realum = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo número real.");
            float realdois = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro número real.");
            float realtres = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o quarto número real.");
            float realquatro = float.Parse(Console.ReadLine());

            Console.WriteLine($"{realum,6:f2}");
            Console.WriteLine($"{realdois,6:f2}");
            Console.WriteLine($"{realtres,6:f2}");
            Console.WriteLine($"{realquatro,6:f2}");
        }
    }
}
