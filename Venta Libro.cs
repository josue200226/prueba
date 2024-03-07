using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AportePrimerParcialB
{
    public class VentaLibro
    {
        public Libro Libro { get; }
        public string Cliente { get; }
        public DateTime FechaVenta { get; }
        public double TotalaPagar { get; }

        public VentaLibro(Libro libro, string cliente, DateTime fechaVenta, double totalaPagar)
        {
            Libro = libro;
            Cliente = cliente;
            FechaVenta = fechaVenta;
            TotalaPagar = totalaPagar;
        }

        public override string ToString()
        {
            return $"{FechaVenta} - Cliente: {Cliente} - Total a Pagar: {TotalaPagar:c}";
        }
    }
}