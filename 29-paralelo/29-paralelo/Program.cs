using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_paralelo
{
    internal class PruebaVector10
    {
        private string[] nombres;
        private int[] edades;

        public void Cargar()
        {
            nombres = new string[5];
            edades = new int[5];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre:");
                nombres[f]= Console.ReadLine();
                Console.WriteLine("Ingresa la edad");
                String linea = Console.ReadLine();
                edades[f]= int.Parse(linea);
            }
        }

        public void MayoresEdad()
        {
            Console.WriteLine("Personas mayores de edad.");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edades[f] >= 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            PruebaVector10 pv = new PruebaVector10();
            pv.Cargar();
            pv.MayoresEdad();
        }
    }
}
