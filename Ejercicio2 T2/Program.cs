using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto a pagar: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            int billetesde100 = (int)(monto / 100);
            monto %= 100;

            int billetesde50 = (int)(monto / 50);
            monto %= 50;

            int billetesde20 = (int)(monto / 20);
            monto %= 20;

            int billetesde10 = (int)(monto / 10);
            monto %= 10;

            int monedasde5 = (int)(monto / 5);
            monto %= 5;

            int monedasde2 = (int)(monto / 2);
            monto %= 2;

            int monedasde1 = (int)(monto / 1);
            monto %= 1;

            int monedasde05 = (int)(monto / 0.5m);
            monto %= 0.5m;

            int monedasde02 = (int)(monto / 0.2m);
            monto %= 0.2m;

            int monedasde01 = (int)(monto / 0.1m);
            monto %= 0.1m;

            monto = Math.Round(monto, 2);

            Console.WriteLine("Distribucion de billetes y monedas:");
            Console.WriteLine($"biilletes de 100: {billetesde100}");
            Console.WriteLine($"billetes de 50:{billetesde50}");
            Console.WriteLine($"billetes de 20:{billetesde20}");
            Console.WriteLine($"biilletes de 10: {billetesde10}");
            Console.WriteLine($"monedas de 5:{monedasde5}");
            Console.WriteLine($"monedas de 2:{monedasde2}");
            Console.WriteLine($"monedas de 1:{monedasde1}");
            Console.WriteLine($"monedas de 0.5:{monedasde05}");
            Console.WriteLine($"monedas de 0.2:{monedasde02}");
            Console.WriteLine($"monedas de 0.1:{monedasde01}");
            if (monto > 0)
            {
                Console.WriteLine($"sobran {monto} soles que no se puede repartir con los valores disponibles.");
            }
        }
    }
}
