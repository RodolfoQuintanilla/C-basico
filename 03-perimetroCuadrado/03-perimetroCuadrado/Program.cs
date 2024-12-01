using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
//(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)

namespace _03_perimetroCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int res;
            String linea;

            Console.WriteLine("Ingresa el lado de tu cuadrado");
            linea = Console.ReadLine();
            lado = int .Parse(linea);

            res = lado * 4;
            Console.WriteLine("El Area de tu cuadrado es: ");
            Console.WriteLine(res);

        }
    }
}
