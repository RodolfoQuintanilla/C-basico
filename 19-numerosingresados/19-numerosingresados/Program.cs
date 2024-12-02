using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.

namespace _19_numerosingresados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, tabla=0;
            String puente;

            for (int i = 1; i < 10; i++)
            {
                tabla = i * 5;
                Console.WriteLine(tabla);
            }
        }
    }
}
