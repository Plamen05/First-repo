using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете 10ично число: ");
            int chislo = int.Parse(Console.ReadLine());
            string dvuichno = Convert.ToString(chislo,2);
            Console.WriteLine("Двуично число: {0}", dvuichno);
        }
    }
}
