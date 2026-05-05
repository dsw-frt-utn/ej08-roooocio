using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    public class Product
    {
        private string description;

        public Product(string descripcionInicial)
        {
            this.description = descripcionInicial;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void CambiarDescripcion(string nuevaDesc)
        {
            this.description = nuevaDesc;
        }
    }
}

