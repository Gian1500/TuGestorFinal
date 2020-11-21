using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DataCliente
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=TuGestor; Uid=root; Pwd=1234");

        public DataTable ConsultarTablaClientes()
        {

            MySqlCommand cmd = new MySqlCommand("select * from Clientes", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaClientes = new DataTable();
            mySqlDataAdapter.Fill(tablaClientes);

            return tablaClientes;


        }

        public int Insertar(string nombre, string dni, string direccion, string departamento, string telefono)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Clientes values('" + nombre + "','" + dni + "','" + direccion
                + "','" + departamento + "','" + telefono + "')", conexion);
            //EXCEPCION Duplicate entry,dni.PrimaryKey

            try
            {
                flag = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                
            }
            finally
            {
                conexion.Close();
            }
            return flag;

        }



        public int Eliminar(string dni)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Delete from Clientes where dni='" + dni + "'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

    }
}
