using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Usuario : Persona
    {

        DataUsuario cn = new DataUsuario();
        private string nick;
        private string password;


        public Usuario(string nombre, string dni, string direccion, string departamento, string telefono, string nick, string password) : base(nombre, dni, direccion, departamento, telefono)
        {
            this.nick = nick;
            this.password = password;
        }

        public int conSQL(string User, string Pass)
        {
            return cn.consultaLogin(User, Pass);
        }

        public DataTable ConsultarTablaUsuarios()
        {
            return cn.ConsultarTablaUsuarios();
        }

        public override int InsertarUsuario(string nombre, string dni, string direccion, string departamento, string telefono, string nick, string password)
        {
            int bandera;
            
            //Validacion DNI
            if (nick != "" && password != "" && nombre != "" && dni != "")
            {
                if ((dni.Length == 8 || dni.Length == 7))
                {
                  return cn.InsertarUsuario(nombre, dni, direccion, departamento, telefono, nick, password);
                }
                else
                {
                   return bandera = 2;
                }


            }
            else
            {
               return bandera = 3;
            }
           
        }

         public override int EliminarUsuario(string password, string dni)
        {
            int bandera;

            //Validacion DNI
            if (password != "" && dni != "")
            {
                if ((dni.Length == 8 || dni.Length == 7))
                {
                    return cn.EliminarUsuario(password, dni);
                }
                else
                {
                    return bandera = 2;
                }


            }
            else
            {
                return bandera = 3;
            }

            
        }

        //Sin Implementar
        public override int Insertar(string nombre, string dni, string direccion, string departamento, string telefono)
        {
            throw new NotImplementedException();
        }

        public override int Eliminar(string dni)
        {
            throw new NotImplementedException();
        }
       
    }
}
