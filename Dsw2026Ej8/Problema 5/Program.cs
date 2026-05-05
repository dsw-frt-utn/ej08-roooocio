using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Problema5 p5 = new Problema5();
            RetailSale v1 = new RetailSale { Importe = 1000m };
            WholesaleSale v2 = new WholesaleSale { Importe = 1000m };
            Console.WriteLine($"Venta Minorista: {p5.ObtenerImporteFinal(v1)}"); 
            Console.WriteLine($"Venta Mayorista (10% desc): {p5.ObtenerImporteFinal(v2)}"); 

        }
    }
}
