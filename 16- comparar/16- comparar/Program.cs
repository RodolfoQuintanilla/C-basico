using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa que permita cargar dos listas de 15 valores cada una.
//Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor (mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
//Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.

namespace _16__comparar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, lista=0, acumulaor=0 , acumulaor2 = 0;
            String puente;



            while(i <= 2)
            {
                Console.WriteLine("Ingresa numero de primera lista:  ");
                puente = Console.ReadLine();
                lista= int.Parse(puente);
                acumulaor = acumulaor + lista;
                i++;
            }
            i = 1;
            while (i <= 2)
            {
                Console.WriteLine("Ingresa numero de Segunda lista:  ");
                puente = Console.ReadLine();
                lista = int.Parse(puente);
                acumulaor2 = acumulaor2 + lista;
                i++;
            }


            if (acumulaor>acumulaor2)
            {
                 Console.WriteLine("El acumulado 1 es mayor que  el 2 " + acumulaor);
            }
            if (acumulaor < acumulaor2)
            {
                Console.WriteLine("El acumulado 2 es mayor que  el 1" + acumulaor2);
            }
            if (acumulaor== acumulaor2)
            {
                Console.WriteLine("son iguales  " + acumulaor2);
            }





        }
    }
}
