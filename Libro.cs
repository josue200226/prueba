using Microsoft.VisualBasic.Logging;

namespace AportePrimerParcialB
{
    public class Libro
    {
        public string NombreLibro { get; }
        public string Codigo { get; }
        public string Categoria { get; }
        public double Precio { get; }
        public int Cantidad { get; }

        public Libro(string nombreLibro, string codigo, string categoria, double precio, int cantidad)
        {
            NombreLibro = nombreLibro;
            Codigo = codigo;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
   






