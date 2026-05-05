namespace Ej08Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper ayuda = new ProductHelper();
            Console.WriteLine(ayuda.ObtenerEtiquetaProducto(1, "Pizza", 10.5m));
            Console.WriteLine(ayuda.ObtenerEtiquetaProducto(2, "Queso", 15.5m));

        }

  
    }
}
