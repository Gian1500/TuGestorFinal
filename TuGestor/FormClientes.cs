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
    public partial class FormClientes : Form
    {
        

        public FormClientes()
        {

            InitializeComponent();
            Cliente cliente = new Cliente(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text);
            dataGridViewCliente.DataSource = cliente.ConsultaDT();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevocliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text);

            //Mostrar Mensaje de Validacion
            if (cliente.Insertar(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text) == 0)
            {
                MessageBox.Show("DNI ya registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cliente.Insertar(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text) == 1 )
            {
                MessageBox.Show("Verifique que el DNI tenga 7 u 8 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cliente.Insertar(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text) == 2)
            {
                MessageBox.Show("Complete los campos obligatorios (*)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridViewCliente.DataSource= cliente.ConsultaDT();
       
        }

     

        private void btn_eliminarcliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text);

            //Mostrar Mensaje de Validacion

            if (cliente.Eliminar(txt_dni.Text) == 0)
            {
                MessageBox.Show("Complete el campo DNI correctamente para ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dataGridViewCliente.DataSource = cliente.ConsultaDT();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
