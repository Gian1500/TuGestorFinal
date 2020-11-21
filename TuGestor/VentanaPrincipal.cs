using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuGestor
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            FormClientes fe1 = new FormClientes();
            this.Hide();
            fe1.ShowDialog();
            this.Show();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            FormInventario fi1 = new FormInventario();
            this.Hide();
            fi1.ShowDialog();
            this.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            FormVentas fv1 = new FormVentas();
            this.Hide();
            fv1.ShowDialog();
            this.Show();
        }


        private void btn_Envios_Click(object sender, EventArgs e)
        {
            FormEnvios fen1 = new FormEnvios();
            this.Hide();
            fen1.ShowDialog();
            this.Show();
        }
    }
}
