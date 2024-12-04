using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.
//Obtener la suma de los dos vectores,
//dicho resultado guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.

namespace _26_vectores
{
    internal class Vectores
    {
        private int [] vectorUno;
        private int [] vectorDos;
        public void Inicio() {

            vectorUno= new int[4];
            int num1, num2, num3, num4;


            for (int i = 0; i < vectorUno.Length; i++)
            {
                Console.WriteLine("Ingresa un valor: ");
            String puente = Console.ReadLine();
                vectorUno[i]= int.Parse(puente);
            }
         
        }

        public void Suma1()
        {
            int suma=0;
            for (int i = 0; i < vectorUno.Length; i++)
            {
                suma = suma + vectorUno[i];
            }

            

            Console.WriteLine("La sume del primer vector es: "+suma);
        }

        public void Vecor2()
        {

            vectorDos = new int[4];
            int num1, num2, num3, num4;


            for (int i = 0; i < vectorDos.Length; i++)
            {
                Console.WriteLine("Ingresa un valor: ");
                String puente = Console.ReadLine();
                vectorDos[i] = int.Parse(puente);
            }

        }

        public void Suma2()
        {
            int suma = 0;
            for (int i = 0; i < vectorDos.Length; i++)
            {
                suma = suma + vectorDos[i];
            }

            Console.WriteLine("La sume del segunda vector es: " + suma);
        }


        static void Main(string[] args)
        {
            Vectores res = new Vectores();
            res.Inicio();
            res.Suma1();
            res.Vecor2();
            res.Suma2();
            Console.ReadKey();
        }
    }
}
