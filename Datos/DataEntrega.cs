using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DataEntrega
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=TuGestor; Uid=root; Pwd=1234");

        public DataTable consultaTablaEnvios()
        {
            MySqlCommand cmd = new MySqlCommand("select * from Envios", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaEnvios = new DataTable();
            mySqlDataAdapter.Fill(tablaEnvios);

            return tablaEnvios;
        }

        public int InsertarDatosEnvio(double total, string fecha, string envio, string departamento)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Envios values('" + total + "','" + fecha + "','" + envio + "','"
                + departamento + "')", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

        public DataTable ConsultaOrdenadaDepartamento(string departamento)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM envios WHERE Departamento='" + departamento + "'", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaEnviosOrd = new DataTable();
            mySqlDataAdapter.Fill(tablaEnviosOrd);

            return tablaEnviosOrd;

        }

        public DataTable ConsultaOrdenadaEnvio(string envio)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM envios WHERE Envio='" + envio + "'", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaEnviosOrd = new DataTable();
            mySqlDataAdapter.Fill(tablaEnviosOrd);

            return tablaEnviosOrd;

        }
    }
}
