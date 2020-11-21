using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class DataVenta
    {

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=TuGestor; Uid=root; Pwd=1234");


        public DataTable ConsultarTablaVentas()
        {

            MySqlCommand cmd = new MySqlCommand("select * from Inventario", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaVenta = new DataTable();
            mySqlDataAdapter.Fill(tablaVenta);

            return tablaVenta;


        }

        public int TraerStock(string codigo)
        {

            int cant = 0;

            conexion.Open();

            string query = "Select Stock from Inventario where Codigo='" + codigo + "'";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {

                cant = Convert.ToInt32(reg["Stock"]);
            }


            conexion.Close();

            return cant;


        }

        public int ActualizarStock(string codigo, int stocknuevo)
        {
            int flag;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Update Inventario set Stock='" + stocknuevo + "'where Codigo='" + codigo + "'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

        public double consultaVenta(string codigo)
        {
            double res = 0;

            conexion.Open();

            string query = "select * from Inventario where Codigo='" + codigo + "'";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {

                res = Convert.ToDouble(reg["Precio Venta"]);
            }


            conexion.Close();

            return res;



        }

        public string consultaProducto(string codigo)
        {
            string res;
            string query = "select Nombre from Inventario where Codigo='" + codigo + "'";


            conexion.Open();


            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {

                res = reg["Nombre"].ToString();
            }
            else
            {

                res = "Null";

            }

            conexion.Close();

            return res;


        }
    }
}
