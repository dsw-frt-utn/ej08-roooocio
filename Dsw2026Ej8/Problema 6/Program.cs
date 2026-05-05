using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Problema6 p6 = new Problema6();
            string codigo1 = "   ab 123 x   ";
            string resultado1 = p6.NormalizarCodigoProducto(codigo1);
            Console.WriteLine($"Original: '{codigo1}'");
            Console.WriteLine($"Normalizado: '{resultado1}'"); 
            string codigo2 = null;
            string resultado2 = p6.NormalizarCodigoProducto(codigo2);
            Console.WriteLine($"Original: null");
            Console.WriteLine($"Resultado: {resultado2}"); 
            string codigo3 = "hola mundo c sharp";
            Console.WriteLine($"Original: '{codigo3}'");
            Console.WriteLine($"Normalizado: {p6.NormalizarCodigoProducto(codigo3)}");
        }
    }
}
