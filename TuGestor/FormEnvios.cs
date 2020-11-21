using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;


namespace TuGestor
{
    public partial class FormEnvios : Form
    {
        
        public FormEnvios()
        {
            InitializeComponent();
            Entrega entrega1 = new Entrega();
            dataGridViewEnvio.DataSource = entrega1.ConsultaDTEnvios();
            
        }

        private void btn_CerrarL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btn_BuscarDpto_Click(object sender, EventArgs e)
        {   
            string busqueda;
            Entrega entrega1 = new Entrega();
            try
            {

                if (comboBoxEnvios.SelectedItem.ToString()=="Retiro en local")
                {
                    busqueda = "Retiro en local";
                    dataGridViewEnvioOrd.DataSource = entrega1.ConsultaOrdenadaEnvio(busqueda);
                }
                else if (comboBoxEnvios.SelectedItem.ToString() == "Envio a domicilio")
                {
                    busqueda = "Envio a domicilio";
                    dataGridViewEnvioOrd.DataSource = entrega1.ConsultaOrdenadaEnvio(busqueda);
                }
                else
                {
                    busqueda = comboBoxEnvios.SelectedItem.ToString();
                    dataGridViewEnvioOrd.DataSource = entrega1.ConsultaOrdenadaDepartamento(busqueda);
                }  

            }

            catch (Exception o)
            {

            }
            
        }

    }
}
