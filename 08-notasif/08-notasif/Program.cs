using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_notasif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, resultado;
            String puente;

            Console.WriteLine("Inresa Nota 1");
            puente = Console.ReadLine();
            nota1= float.Parse(puente);
            Console.WriteLine("Inresa Nota 2");
            puente = Console.ReadLine();
            nota2 = float.Parse(puente);
            Console.WriteLine("Inresa Nota 3");
            puente = Console.ReadLine();
            nota3 = float.Parse(puente);

            resultado = (nota1 + nota2 + nota3) / 3;
            if (resultado >= 7) {
                Console.WriteLine("Aprobado "+ "Tu promedio es de: "+resultado );
            }
            else
            {
                Console.WriteLine("reprobado "+ "Tu promedio es de: " + resultado);
            }
        }
    }
}
