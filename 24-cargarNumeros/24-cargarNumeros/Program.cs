using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implementar la clase operaciones. Se deben cargar dos valores enteros,
//calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.

namespace _24_cargarNumeros
{
    internal class Opreraciones
    {
        private int num1, num2;


        public void Inicializar()
        {
            Console.Write("Ingresa primer numero: ");
            String puente = Console.ReadLine();
            num1 = int.Parse(puente);
            Console.Write("Ingresa primer numero: ");
            puente = Console.ReadLine();
            num2 = int.Parse(puente);
        }

        public void Suma()
        {
            int resultado = 0;
            resultado=  num1 + num2;
            Console.WriteLine("El resultado de la suma es: "+ resultado);
        }

        public void Resta()
        {
            int resultado = 0;
            resultado = num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
        }

        public void Multiplicacion()
        {
            int resultado = 0;
            resultado = num1 * num2;
            Console.WriteLine("El resultado de la multiplicasion es: " + resultado);
        }

        public void Divicion()
        {
            int resultado = 0;
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la Divicion es: " + resultado);
        }
        static void Main(string[] args)
        {
            Opreraciones opreracion1 = new Opreraciones();
            opreracion1.Inicializar();
            opreracion1.Suma();
            opreracion1.Resta();
            opreracion1 .Multiplicacion();
            opreracion1.Divicion();
            Console.ReadKey();
        }
    }
}
