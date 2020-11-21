using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DataUsuario
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=TuGestor; Uid=root; Pwd=1234");

        public int consultaLogin(string Usuario, string Contraseña)
        {

            int count;

            conexion.Open();

            string Query = "Select Count(*) From Usuarios where Usuario='" + Usuario + "'" + "and Contraseña='" + Contraseña + "'";

            MySqlCommand cmd = new MySqlCommand(Query, conexion);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return count;

        }

        public int InsertarUsuario(string nombre, string dni, string direccion, string departamento, string telefono, string nick, string password)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Usuarios values('" + nick + "','" + password + "','" + nombre + "','" + dni + "','" + direccion + "','"
                + departamento + "','" + telefono + "')", conexion);

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



        public int EliminarUsuario(string password, string dni)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Delete from Usuarios where Dni='" + dni + "' AND Contraseña='" + password + "'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

        public DataTable ConsultarTablaUsuarios()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select Dni from Usuarios", conexion);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                DataTable tablaUsuarios = new DataTable();
                mySqlDataAdapter.Fill(tablaUsuarios);

                return tablaUsuarios;
            }
            catch (Exception e)
            {
                MySqlCommand cmd = new MySqlCommand("select Dni from Usuarios", conexion);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                DataTable tablaUsuarios = new DataTable();
                mySqlDataAdapter.Fill(tablaUsuarios);

                return tablaUsuarios;
            }

        }


    }
}
