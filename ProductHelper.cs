using System;
using System.Collections.Generic;
using System.Text;

namespace Ej08Problema1
{
   public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description,decimal price)
        {
            return $"[{code}] {description}{Separador}{price:C}";
        }
    }
}
