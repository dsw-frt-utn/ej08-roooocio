using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    public class Sale
    {
        public decimal Importe { get; set; }
        public virtual decimal CalculateTotal()
        {
            return Importe;
        }

    }
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe * 0.9m;
        }
    }
    
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe; 
        }
    }
}
