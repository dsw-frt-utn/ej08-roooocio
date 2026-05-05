using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Problema4 p4 = new Problema4();
            double prom1 = p4.CalcularPromedio(8, null, 10);
            Console.WriteLine($"Promedio 8, null, 10: {prom1}"); 
            double prom2 = p4.CalcularPromedio(null, null, null);
            Console.WriteLine($"Promedio todos null: {prom2}");
            double prom3 = p4.CalcularPromedio(7, 20, -5);
            Console.WriteLine($"Promedio 7, 20, -5: {prom3}"); 
        }
    }
}
