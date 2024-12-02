using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_triangulos
    //Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y la altura de un triángulo. El programa deberá informar:
//a) De cada triángulo la medida de su base, su altura y su superficie.
//b) La cantidad de triángulos cuya superficie es mayor a 12.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int triangulos=0, b = 0, a=0, resultado = 0, mayor = 0, menor=0;
            String puente;

            Console.WriteLine("Cuntos Trinagulos quieres calcular: ");
            puente = Console.ReadLine();
            triangulos=int.Parse(puente);

            for (int i = 1; i <= triangulos ; i++)
            {
                Console.WriteLine("Ingreda la Base");
                puente= Console.ReadLine();
                b=int.Parse(puente);

                Console.WriteLine("Ingreda el atura");
                puente = Console.ReadLine();
                a = int.Parse(puente);

                resultado = b * a / 2;

                if (resultado>=12)
                {
                    mayor++;
                }
                else
                {
                    menor++;
                }
            }

            Console.WriteLine("El superficie del triangulo es: "+ resultado);
            Console.WriteLine("Triangulos mayor a 12: " + mayor);
            Console.WriteLine("Triangulos menor a 12: " + menor);
        }
    }
}
