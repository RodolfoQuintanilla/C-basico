using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            String linea;
            Console.WriteLine("Inpresa Primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Inpresa Segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;
            Console.WriteLine("La suma de los dos valores es: ");
            Console.WriteLine(suma);
            Console.WriteLine(producto);
            Console.ReadKey();
        }
    }
}
