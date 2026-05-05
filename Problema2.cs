using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ej08Problema2
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal totalCalculado = quantity > 0 ? (quantity * unitPrice) : 0;

            var resumen = new //clase anonima
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total:C}";
         }

    }

         
}
    

