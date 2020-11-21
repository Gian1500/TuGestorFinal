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
    public partial class FormVentas : Form
    {
        
        public double resultado = 0 ;
        private DataTable dt;
        public DateTime fecha;
        public string departamento;
        public string entrega;


        public FormVentas()
        {
            InitializeComponent();
            Venta venta = new Venta(txt_busquedaCod.Text, txt_cantidadProd.Text);
            dataGridViewVentas.DataSource = venta.ConsultaDTVentas();

            dt = new DataTable();
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Total");

            dataGridViewCarrito.DataSource = dt;


        }

        private void btn_agregarVenta_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
           Venta venta = new Venta(txt_busquedaCod.Text, txt_cantidadProd.Text);
           try
            {
               if (venta.calcularTotal()== -1)
                {
                    MessageBox.Show("Rellene CORRECTAMENTE todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (venta.consultaProducto(txt_busquedaCod.Text) == "Null")
                    {
                        MessageBox.Show("El producto buscado no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        //Funcion del btn_agregarcompra


                        if (venta.stockanterior < Convert.ToInt32(txt_cantidadProd.Text))
                        {
                            MessageBox.Show("No Hay STOCK suficiente del producto seleccionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {   

                            //CREA LA FILA DE COMPRAS
                            DataRow row = dt.NewRow();

                            row["Producto"] = venta.consultaProducto(txt_busquedaCod.Text);
                            row["Cantidad"] = txt_cantidadProd.Text;
                            row["Precio Unitario"] = venta.consultaVenta(txt_busquedaCod.Text);
                            row["Total"] = venta.totalVenta;

                            dt.Rows.Add(row);

                            resultado = resultado + venta.calcularTotal();
           
                            venta.ActualizarStock(txt_busquedaCod.Text, 0);

                            dataGridViewVentas.DataSource = venta.ConsultaDTVentas();

                            label_total.Text = resultado.ToString();
                            
                            //Validacion comboBox
                            if (comboBox1.Enabled == true)
                            {
                                try
                                {
                                    departamento = comboBox1.SelectedItem.ToString();
                                }
                                catch (Exception i)
                                {
                                    departamento = "No especificado";
                                }
                                
                            }


                        }


                    }


                }
            }
            catch (Exception r)
            {

            }

            //Toma de datos para form envios
            venta.fecha = dateTimePicker1.Value;
            if (Envio.Checked == true)
            {
                venta.entrega = "Envio a domicilio";
            }
            else
            {
                venta.entrega = "Retiro en local";
            }


            try
            {
                venta.departamento = comboBox1.SelectedItem.ToString();
            }
            catch (Exception err)
            {
                venta.departamento = "No especificado";
            }


            Entrega entrega = new Entrega();

            entrega.InsertarDatosEnvio(venta.totalVenta, venta.fecha, venta.entrega, venta.departamento);




        }

        private void btn_CerrarV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void EnPuerta_CheckedChanged(object sender, EventArgs e)
        {
            if (EnPuerta.Checked == true)
            {
                comboBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
            

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
