using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_poo
{
    internal class Persona
    {
        private string nombre;
        private int edad;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese en nombre ");
            nombre= Console.ReadLine();
            String linea;
            Console.WriteLine("Ingrese la edad: ");
            linea= Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("datos de la persona ");
            Console.Write("nombre");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if(edad >= 18)
            {
                Console.WriteLine("Es mayor de edad la persona: ");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Inicializar();
            persona1.Imprimir();
            persona1. EsMayorEdad();
            Console.ReadKey();
        }
    }
}
