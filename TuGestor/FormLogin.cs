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
    public partial class FormLogin : Form
    {

        
        public FormLogin()
        {

            InitializeComponent();
            Usuario usuario = new Usuario(txt_NombreLogin.Text, txt_dni.Text, txt_direccion.Text, txt_depart.Text, txt_telefono.Text,
               txt_nick.Text, txt_pass.Text);
            dataGridViewLogin.DataSource = usuario.ConsultarTablaUsuarios();
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txt_NombreLogin.Text, txt_dni.Text, txt_direccion.Text, txt_depart.Text, txt_telefono.Text,
               txt_nick.Text, txt_pass.Text);

            if (usuario.conSQL(txt_Usuario.Text,txt_Contraseña.Text)==1)
            {
                MessageBox.Show("Logueado Satisfactoriamente");

                this.Hide();

                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("El Nombre de Usuario o la Contraseña son incorrectos");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked == true)
            {
                txt_Contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txt_NombreLogin.Text, txt_dni.Text, txt_direccion.Text, txt_depart.Text, txt_telefono.Text,
               txt_nick.Text, txt_pass.Text);

            //Visualizacion de MessageBox de validacion de DNI y de Campos obligatorios

            
            if (usuario.InsertarUsuario(txt_NombreLogin.Text, txt_dni.Text, txt_direccion.Text, txt_depart.Text, txt_telefono.Text,
               txt_nick.Text, txt_pass.Text) == 2)
            {
                MessageBox.Show("Verifique que el DNI tenga 7 u 8 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(usuario.InsertarUsuario(txt_NombreLogin.Text, txt_dni.Text, txt_direccion.Text, txt_depart.Text, txt_telefono.Text,
               txt_nick.Text, txt_pass.Text) == 3)
            {
                 MessageBox.Show("Complete los campos obligatorios (*)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dataGridViewLogin.DataSource = usuario.ConsultarTablaUsuarios();
        }

        private void btn_EliminarU_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txt_NombreLogin.Text, txt_borrarDni.Text, txt_direccion.Text, txt_depart.Text, txt_telefono.Text,
               txt_nick.Text, txt_borrarPass.Text);

            //Visualizacion de MessageBox de validacion de DNI y de Campos obligatorios

            if (usuario.EliminarUsuario(txt_borrarPass.Text, txt_borrarDni.Text) == 0)
            {
                MessageBox.Show("DNI o Contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.EliminarUsuario(txt_borrarPass.Text, txt_borrarDni.Text) == 2)
            {
                MessageBox.Show("Verifique que el DNI tenga 7 u 8 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.EliminarUsuario(txt_borrarPass.Text, txt_borrarDni.Text) == 3)
            {
                MessageBox.Show("Ambos campos deben estar completos para ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridViewLogin.DataSource = usuario.ConsultarTablaUsuarios();
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

    
    }
}
