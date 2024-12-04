using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector.

namespace ConsoleApp1
{
    internal class Ordenamiento
    {
        private int[] sueldos;

        public void Cargar()
        {
  sueldos = new int[5];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine("Ingresa el sueldo");
                sueldos[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Oredebar() {
            for (int k = 0; k < 4; k++)
            {
                for (int f=0; f<4;f++)
                {
                    if (sueldos[f] > sueldos[f+1])
                    {
                        int aux = sueldos[f];
                        sueldos[f] = sueldos[f+1];
                        sueldos[f+1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("ESueldo oredenado de mayor a menor es: ");
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
        }

        static void Main(string[] args)
        {
            Ordenamiento or = new Ordenamiento();
            or.Cargar();
            or.Oredebar();
            or.Imprimir();
            Console.ReadKey();


        }
    }
}
