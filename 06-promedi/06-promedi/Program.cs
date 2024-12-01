using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

namespace _06_promedi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, total;
            String text;
            Console.WriteLine("Ingresa Primer Numero: ");
           text= Console.ReadLine();
            num1 = int.Parse(text);
            Console.WriteLine("Ingresa Segundo Numero: ");
            text = Console.ReadLine();
            num2 = int.Parse(text);
            Console.WriteLine("Ingresa Tercer Numero: ");
            text = Console.ReadLine();
            num3 = int.Parse(text);
            Console.WriteLine("Ingresa Cuart Numero: ");
            text = Console.ReadLine();
            num4 = int.Parse(text);

            suma = num1+ num2+num3+num4;

            total = suma / 4;
            Console.WriteLine("El resultado de la suma es: ");
            Console.WriteLine(suma);
            Console.WriteLine("El promedio: ");
            Console.WriteLine(total);
        }
    }
}
