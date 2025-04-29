using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo del empleado:");
            decimal sueldo = decimal.Parse(Console.ReadLine());
            decimal descuento = 0;

            if (sueldo <= 1500)
            {
                descuento = 0.10m;
            }
            else if (sueldo > 1500 && sueldo <= 3000)
            {
                descuento = 0.05m;
            }
            else if (sueldo > 3000)
            {
                descuento = 0.03m;
            }
            decimal montodescuento = sueldo * descuento;
            decimal sueldoneto = sueldo - montodescuento;
            Console.WriteLine($"descuento:{montodescuento:c}");
            Console.WriteLine($"Sueldo neto:{sueldoneto:c}");
        }
    }
}
