using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_notaswhile
{
    internal class Program
    {
        static void Main(string[] args)

        {
            float n = 1, x;
            String puente;
            while (n<=9)
            {
                Console.WriteLine("Numero");
                puente = Console.ReadLine();
                x= float.Parse(puente);

                Console.WriteLine(x);
            }
        }
    }
}
