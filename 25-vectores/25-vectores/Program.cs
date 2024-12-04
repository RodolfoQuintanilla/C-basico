using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
//1.-El valor acumulado de todos los elementos del vector.
//El valor acumulado de los elementos del vector que sean mayores a 36.
//Cantidad de valores mayores a 50.

namespace _25_vectores
{
    internal class Vector
    {

        private int[] acumulador;
        private int datos;

        public void Inicio()
        {
            acumulador = new int[8];

            for (int i = 0; i < acumulador.Length; i++)
            {
               Console.WriteLine("Ingresa un numero: ");
                String puente = Console.ReadLine();
                acumulador[i]= int.Parse(puente);

            }

        }


        public void AcumuladorElementos() {
            int suma = 0;
            for (int i = 0; i < acumulador.Length; i++)
            {
                suma = suma + acumulador[i];
            }

            Console.WriteLine("La suma de todo es: "+suma);
        }

        public void productos()
        {
            int mayor=0, menor=0;

            for (int i = 0; i < acumulador.Length; i++)
            {
                if (acumulador[i] <= 49)
                {
                    menor++;
                }
                else
                {
                    mayor++;
                }
            }

            Console.WriteLine("mayores a 36 "+ menor);
            Console.WriteLine("mayores a 50 " + mayor);
        }


        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Inicio();
            v.AcumuladorElementos();
            v.productos();
            Console.ReadLine();


        }
    }
}
