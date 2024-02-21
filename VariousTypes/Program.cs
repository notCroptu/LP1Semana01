using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3 - inteiras
            sbyte bite = 18;
            short shorty = 216;
            int inty = 432;
            long longudo = 864L;

            byte bity = 81;
            ushort shortx = 612;
            uint unity = 234U;
            ulong longface = 468UL;

            Console.WriteLine($"This is sbyte: {bite}");
            Console.WriteLine($"This is short: {shorty}");
            Console.WriteLine($"This is int: {inty}");
            Console.WriteLine($"This is long: {longudo}");

            Console.WriteLine($"This is byte: {bity}");
            Console.WriteLine($"This is ushort: {shortx}");
            Console.WriteLine($"This is uint: {unity}");
            Console.WriteLine($"This is ulong: {longface}");
        }
    }
}
