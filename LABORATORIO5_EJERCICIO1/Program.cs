using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO5_EJERCICIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            for (int i = 0; i < num2; i++)
            {
                resultado += num;
            }

            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
