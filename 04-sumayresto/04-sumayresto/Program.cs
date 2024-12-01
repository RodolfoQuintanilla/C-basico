using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un programa en el cual se ingresen cuatro números, calcular e 
//    informar la suma de los dos primeros y el producto del tercero y el cuarto.

namespace _04_sumayresto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, opera, opera2 ;
            String stri;

            Console.WriteLine("Ingres el primer Numero: ");
            stri = Console.ReadLine();
            num1 = int.Parse(stri);
            Console.WriteLine("Ingresa el Segundo Numero: ");
            stri = Console.ReadLine();
            num2 = int.Parse(stri);
            Console.WriteLine("Ingres el tercer Numero: ");
            stri = Console.ReadLine();
           
            num3 = int.Parse(stri);
            Console.WriteLine("Ingresa el cuarto Numero: ");
            stri = Console.ReadLine();
            num4 = int.Parse(stri);

            opera = num1 + num2;
            opera2 = num3 % num4;

            Console.WriteLine("El resultado de la suma es: ");
            Console.WriteLine(opera);
            Console.WriteLine("El resultado resto es: ");
            Console.WriteLine(opera2);
            Console.ReadKey();
        }
    }
}
