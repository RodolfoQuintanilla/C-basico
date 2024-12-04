using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se tienen las notas del primer parcial de los alumnos de dos cursos,
//el curso A y el curso B, cada curso cuenta con 5 alumnos.
//Realizar un programa que muestre el curso que obtuvo el mayor promedio general.

namespace _27_vectabc
{
    internal class Program
    {

        private float [] cursoA;
        private float [] cursoB;

        public void inicio()

        {
            cursoA = new float [5];
            cursoB = new float [5];

            for (int i = 0; i < cursoA.Length; i++)
            {
                int nota = 0;
                Console.WriteLine("Ingresa la nota correspondiente al curso 'A': ");
                String puente = Console.ReadLine();
                cursoA[i] = int.Parse(puente);
            }

            for (int i = 0; i < cursoA.Length; i++)
            {
                int nota2 = 0;
                Console.WriteLine("Ingresa la nota correspondiente al curso 'B': ");
                String puente = Console.ReadLine();
                cursoB[i] = int.Parse(puente);
            }
           
        }

       public void Promedio()
        {

            float suma = 0;

            float suma2 = 0;

            for (int i = 0; i < cursoA.Length; i++)
            {
                suma = suma+ cursoA[i];
            }

            for (int x = 0; x < cursoB.Length; x++)
            {
                suma2 = suma2 + cursoB[x];
            }

         


            if (suma>=suma2)
            {
                Console.WriteLine("El vector mayor promedio de todo es A: " + suma / cursoA.Length);
                Console.WriteLine("El vector Menor promedio de todo es B: " + suma2 / cursoA.Length);
            }
            else
            {
                Console.WriteLine("El vector mayor promedio de todo es B: " + suma2 / cursoB.Length );
                Console.WriteLine("El vector Menor promedio de todo es a: " + suma / cursoA.Length);
            }
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1 .inicio();
            p1 .Promedio();
           
            Console.ReadKey();
        }
    }
}
