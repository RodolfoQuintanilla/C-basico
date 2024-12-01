using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_digitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num2, res;
            String puente;
            Console.WriteLine("Ingresa un numero del 1 al 99");
            puente = Console.ReadLine();
            num = int.Parse(puente);

            if (num <=9)
            {
                Console.WriteLine("El numeor es de un digito" + " " + num);
            }
            else
            {
                Console.WriteLine("El numeor es de dos digitos"+" "+num);
            }

        }
    }
}
