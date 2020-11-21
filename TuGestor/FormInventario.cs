using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TuGestor
{
    public partial class FormInventario : Form
    {
        

        public FormInventario()
        {

            InitializeComponent();
            Producto producto = new Producto(txt_NombreProd.Text,txt_CodigoProd.Text,txt_Stock.Text,txt_PrecioC.Text,
                txt_PrecioV.Text);
            dataGridViewInv.DataSource = producto.ConsultaDTInv();
        }

        private void btn_AgregarInv_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(txt_NombreProd.Text, txt_CodigoProd.Text, txt_Stock.Text, txt_PrecioC.Text, 
                txt_PrecioV.Text);

            //Mostrar MessageBox para Validacion
            if (producto.InsertarProducto()==1)
            {
                producto.InsertarProducto();
                
            }
            else
            {
                MessageBox.Show("Llene correctamente todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridViewInv.DataSource = producto.ConsultaDTInv();

        }

        private void btn_EliminarInv_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto(txt_NombreProd.Text, txt_CodigoProd.Text, txt_Stock.Text, txt_PrecioC.Text,
                txt_PrecioV.Text);

            //Mostrar MessageBox para Validacion

            if (producto.EliminarProducto() == 0)
            {
                MessageBox.Show("Revise el código del producto a eliminar");
            }
            else
            {
                producto.EliminarProducto();

                dataGridViewInv.DataSource = producto.ConsultaDTInv();
            }
            
        }

        private void btn_CerrarInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_PrecioU_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void compruebaSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txt_Stock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
