using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas

namespace _13_promediStatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personaN;
            float x = 1, altura=0 , valor=0, promedio = 0 ;
            String puente;
            Console.WriteLine("Ingresa Numero de Persona: ");
            puente = Console.ReadLine();
            personaN = int.Parse(puente);


            while (x <= personaN) {
                Console.WriteLine("Ingresa Estatura: ");
                puente = Console.ReadLine();
                altura = float.Parse(puente);
                valor = valor + altura;
                promedio = valor/personaN;
                x++;
            }


            Console.WriteLine("Numero de personas: "+ personaN);
            Console.WriteLine("suma de alturas: " + valor);
            Console.WriteLine("Promedo de estaturas "+promedio);
            Console.ReadKey();
        }
    }
}
