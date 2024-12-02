using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado

namespace _15_25terminos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, x = 1, res=0;
            string puente;


            Console.WriteLine("Ingresa a multiplicar");
            puente = Console.ReadLine(); 
            n = int.Parse(puente);

            while (x <= 25)
            {
                res = res + n;

                Console.WriteLine(x + "-" + res );
                x++;
            }
           
        }
    }
}
