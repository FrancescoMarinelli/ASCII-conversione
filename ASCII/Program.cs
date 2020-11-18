using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci carattere ASCII");
            char caratteredec = Convert.ToChar(Console.ReadLine());
            ushort carattereASCII = 0;
            carattereASCII = caratteredec;
            string num1 = Convert.ToString(carattereASCII, 2).PadLeft(16, '0');
            Console.WriteLine($"Carattere {caratteredec} - Carattere in ASCII {carattereASCII} - NumeroBinario {num1}");
            Console.ReadLine();
        }
    }
}
