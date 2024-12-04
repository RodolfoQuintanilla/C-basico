using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. Confeccionar los métodos para la carga, 
  //otro para imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)

namespace _22_EmpleadoPoo
{
    internal class Empleado
        
    {
        private float num;
        private String persona;

        public void Inicializar()
        {
            Console.Write("Ingresa el Nombre: ");
            string linea;
            persona = Console.ReadLine();
            Console.Write("Ingresa el salario: ");
            linea = Console.ReadLine();
            num = float.Parse(linea);
        }


        void Calcular()
        {
            if (num>=3000)
            {
                Console.WriteLine(persona + " Paga Inpuestos");
            }
            else
            {
                Console.WriteLine(persona + " NO Paga Inpuestos");
            }
        }


        public void Imprimir()
        {
            Console.Write("Nombre es: ");
            Console.WriteLine(persona);
            Console.Write("Edad es: ");
            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            Empleado empl= new Empleado();
            empl.Inicializar();
            empl.Calcular();
            empl.Imprimir();
        }
    }
}
