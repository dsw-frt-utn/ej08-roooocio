using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product miProducto = new Product("Original");

            Problema3 p3 = new Problema3();
            string resultado = p3.CompararCopias(10, miProducto);

            Console.WriteLine(resultado);

        }
    }
}
