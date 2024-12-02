using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.

namespace _12_notaswhile
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int x=1, suma=0, valor, aprovatorio=0, reprovatorio=0;
            String puente;
            while (x<=2)
            {
                Console.WriteLine("Ingresa primera nota {x}: ");
                puente = Console.ReadLine();
                valor = int.Parse(puente);
                if (valor >= 7)
                {
                    aprovatorio= aprovatorio+1;
                }
             else
                {
                    reprovatorio= reprovatorio+1;
                }
               
                x++;
            }
            Console.WriteLine("numeor aprovatorio: " + aprovatorio);
            Console.WriteLine("numeor reprobatorio: " + reprovatorio);

            Console.ReadKey();
        }
    }
}
