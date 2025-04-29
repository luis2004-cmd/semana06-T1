using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            {
            }
            int suma = 0;
            int original = numero;

            while (numero > 0)
            {
                int digito = numero % 10;
                suma += digito;
                numero /= 10;
            }
            Console.WriteLine($"La suma de los digitos de{original} es: {suma}");
        }
    }
}
