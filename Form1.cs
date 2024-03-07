using System.Drawing;

namespace AportePrimerParcialB
{
    public partial class Form1 : Form
    {
        private List<VentaLibro> ventas;

        public Form1()
        {
            InitializeComponent();
            ventas = new List<VentaLibro>();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string NombreLibro = txtNombreproducto.Text;
            string Codigo = txtCodigo.Text;
            string Categoria = txtCategoria.Text;
            double Precio = Convert.ToDouble(txtPrecio.Text);
            int Cantidad = Convert.ToInt32(txtCantidad.Text);
            string Cliente = txtCliente.Text;
            int EdadCliente = Convert.ToInt32(txtEdadCliente.Text);
            DateTime fechaVenta = DateTime.Now;

            Libro libro = new Libro(NombreLibro, Codigo, Categoria, Precio, Cantidad);
            RegistrarVentaLibro(libro, Cliente, EdadCliente, fechaVenta);

            LimpiarControles();
            MostrarVentas();
        }

        private void LimpiarControles()
        {
            txtNombreproducto.Text = "";
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtCliente.Text = "";
            txtEdadCliente.Text = "";
        }

        private void MostrarVentas()

        {
            string mensaje = "Ventas Realizadas :\n\n";
            foreach (VentaLibro venta in ventas)
            {
                mensaje += venta.ToString() + $"\nIVA: {venta.Libro.Precio * 0.12:c}\n\n";
            }

            MessageBox.Show(mensaje, "Ventas Realizadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegistrarVentaLibro(Libro libro, string cliente, int edadCliente, DateTime fechaVenta)
        {
            double descuento = 0;

            if (fechaVenta.DayOfWeek == DayOfWeek.Friday)
            {
                descuento += libro.Precio * 0.8;
            }
            if (edadCliente >= 65)
            {
                descuento += libro.Precio * 0.10;
            }

            double subtotal = libro.Precio - descuento;
            double iva = subtotal * 0.12;
            double totalPagar = subtotal + iva;

            VentaLibro venta = new VentaLibro(libro, cliente, fechaVenta, totalPagar);
            ventas.Add(venta);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}