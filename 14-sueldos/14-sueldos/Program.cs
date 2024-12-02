using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
//realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300.
// Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.


namespace _14_sueldos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empleado, x=1, cien=0,docientos=0,trecientos=0 ;
            float salario = 0, total= 0;
            String puente;

            Console.WriteLine("Ingresa numero de Empleados a calcular: ");
            puente = Console.ReadLine();
            empleado=int.Parse(puente);

            while (x <= empleado) {
                Console.WriteLine("Ingresa el salario del Empleado: ");
                puente=Console.ReadLine();
                salario=int.Parse(puente);

                total = total+ salario;

                if (salario<= 100)
                {
                    cien++;
                }
                if (salario >= 101)
                {
                    docientos++;
                }
                if (salario >= 300)
                {
                    trecientos++;
                }
                x++;
            }

            Console.WriteLine("El numero de empleados son: " +empleado);
            Console.WriteLine("empleados que ganan -100: " + cien);
            Console.WriteLine("empleados que ganan 200 o mas: " + docientos);
            Console.WriteLine("empleados que ganan 300 o mas: " + trecientos);
            Console.WriteLine("Importe total de salarios: " + total);
            Console.ReadLine();
        }
    }
}
