using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sumaresta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2, res, res2;
            String puente;

            Console.WriteLine("Ingresa el Primer Numero: ");
          puente = Console.ReadLine();
            num1 = int.Parse(puente);
            Console.WriteLine("Ingresa el segundo Numero: ");
            puente = Console.ReadLine();
            num2 = int.Parse(puente);

            if (num1 >= num2) {
                res = num1 + num2;
                res2 = num2 * num1;

                Console.WriteLine("el Primer numero es mayor" +" " +"El resultado de la suma es "+ res+" " + "El resultado de la multiplicacion es: " + res2);
              
            }
            else
            {
                res = num1 / num2;
                res2 = num2 % num1;

                Console.WriteLine("el Segundo numero es mayor" + " " + "El resultado de la divicion es " + res + " " + "El resultado de la resto es: " + res2);

            }
        }
    }
}
