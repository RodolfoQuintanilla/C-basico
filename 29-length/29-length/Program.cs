using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_length
{
    internal class Sueldos
    {
        int[] valor;

        public void saludo()
        {
         
            int personas = 0;
            Console.WriteLine("Ingresa el tamaño del vector: ");
            String puente = Console.ReadLine();
            valor = new int[int.Parse(puente)];

            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("Ingresa un digito: ");
                String puente2 = Console.ReadLine();
                valor[i]=int.Parse(puente2);
            }


        }

        public void Suma()
        {
            int suma = 0;
            for (int i = 0; i < valor.Length; i++)
            {
                suma+= valor[i];
            }

            Console.WriteLine("El resultado de la suma es: " + suma);
        }

        static void Main(string[] args)
        {
            Sueldos S1= new Sueldos();
            S1.saludo();
            S1.Suma();
            Console.ReadKey();
        }
    }
}
