using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_caja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float precio, saldo;
            int articulo ;
            String puente;

            Console.WriteLine("Ingrea el precio del articulo: ");
            puente = Console.ReadLine();
            precio = float.Parse(puente);
            Console.WriteLine("Ingrea la cantidad ");
            puente = Console.ReadLine();
            articulo = int.Parse(puente);

            saldo = articulo * precio;


            Console.WriteLine("el resultado es: ");
            Console.WriteLine(saldo);
        }
    }
}
