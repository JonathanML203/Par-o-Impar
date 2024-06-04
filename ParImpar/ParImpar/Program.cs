using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce un número:");
            string input = Console.ReadLine();
            int numero;
            if (int.TryParse(input, out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número " + numero + " es par.");
                }
                else
                {
                    Console.WriteLine("El número " + numero + " es impar.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
            }
        }
    }
}
