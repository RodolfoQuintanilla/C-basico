using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Paresnones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, n = 0, acumulador = 0, inpar=0;
            String puente;
            while (x<= 4 )
            {
                Console.WriteLine("Ingresa numero");
                puente= Console.ReadLine();
                n= int.Parse(puente);


                if (n%2==0)
                {
                    acumulador++;
                }
                else
                {
                    inpar++;
                }
                x++;
            }
            Console.WriteLine("pares" + acumulador);
            Console.WriteLine("inpares" + inpar);
            Console.ReadKey();
        }
    }
}
