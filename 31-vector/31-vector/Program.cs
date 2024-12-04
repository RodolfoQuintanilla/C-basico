using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_vector
{
    internal class Orden
    {
        private int[] numr;

        public void Ingresar()
        {
            numr = new int[4];

            for (int i = 0; i < numr.Length; i++)
            {
      
                Console.WriteLine("Ingresa un numero: ");
                String puente = Console.ReadLine();
                numr [i]= int.Parse(puente);
            }

        }

        public void Ordenar()
        {
           

            for (int x=0; x<4; x++)
            {
                for (int i = 0; i < 4-x; i++)
                {
                    if (numr[i]> numr[i+ 1])
                    {
                        int aux;
                        aux = numr[i];
                        numr[i] = numr[i+ 1];
                        numr[i+ 1] = aux;
                    }

                }
            }

           
        }


       

        static void Main(string[] args)
        {
            Orden od = new Orden();
            od.Ingresar();
            od.Ordenar();
            Console.ReadKey();
        }
    }
}
