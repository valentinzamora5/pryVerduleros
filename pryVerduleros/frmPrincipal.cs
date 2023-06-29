using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using System.Windows.Forms;
using System.IO;

namespace pryVerduleros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public string Conexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.Mdb";

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.CargarTabla(Conexion2, "Ventas", dgvVentas);
            clsBaseDeDatos.CargarProductos(Conexion2, "Productos", cmbProducto);
            clsBaseDeDatos.CargarVendedores(Conexion2, "Vendedores", cmbVendedor);
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.GrabarVentas(Conexion2, "Ventas", Convert.ToInt32(cmbVendedor.SelectedValue), Convert.ToInt32(cmbProducto.SelectedValue), dtpFecha.Value, Convert.ToInt32(numKilos.Value));
            clsBaseDeDatos.CargarTabla(Conexion2, "Ventas", dgvVentas);
        }

        
    }
}
