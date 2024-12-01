using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_anidadas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            String puente;

            Console.WriteLine("Ingresa Primer numero: ");
            puente = Console.ReadLine();
            n1= int.Parse(puente);

            Console.WriteLine("Ingresa Segundo numero: ");
            puente = Console.ReadLine();
            n2 = int.Parse(puente);

            Console.WriteLine("Ingresa Tercer numero: ");
            puente = Console.ReadLine();
            n3 = int.Parse(puente);


            if (n1 >= n2&& n1>=n3)
            {
                Console.WriteLine("El primer numero es mayor: ");
            }
            else
            {
                if (n2 >= n1 && n2 >= n3)
                {
                    Console.WriteLine("El  segundo es mayor: ");
                }
                else
                {
                    Console.WriteLine("El tercero numero es mayor: ");
                }
            }
        }
    }
}
