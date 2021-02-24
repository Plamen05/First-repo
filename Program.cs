using System;

namespace _10kam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете десетично число");
            int chislo = int.Parse(Console.ReadLine());
            string chislo2 = Convert.ToString(chislo, 2);
            Console.WriteLine("10ichno: " + chislo);
            Console.WriteLine("2ichno: " + chislo2);
            string chislo16 = Convert.ToString(chislo, 16);
            Console.WriteLine("16isetichno: " + chislo16);
        }
    }
}
