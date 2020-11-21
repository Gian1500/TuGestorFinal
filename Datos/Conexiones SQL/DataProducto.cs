using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DataProducto
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=TuGestor; Uid=root; Pwd=1234");

        public DataTable ConsultarTablaInventario()
        {

            MySqlCommand cmd = new MySqlCommand("select * from Inventario", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaInventario = new DataTable();
            mySqlDataAdapter.Fill(tablaInventario);

            return tablaInventario;


        }

        public int InsertarProducto(string codigo, string nombre, string stock, string pCosto, string pVenta)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Inventario values('" + codigo + "','" + nombre + "','" + stock + "','"
                + pCosto + "','" + pVenta + "')", conexion);

            //EXCEPCION Duplicate entry,Codigo.PrimaryKey

            try
            {
                flag = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                conexion.Close();
            }
            return flag;
        }



        public int EliminarProducto(string codigo)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Delete from Inventario where codigo='" + codigo + "'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }
    }
}
