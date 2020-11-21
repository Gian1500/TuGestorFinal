using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Cliente : Persona
    {

        DataCliente cn = new DataCliente();

        public Cliente(string nombre_apellido, string dni, string direccion, string departamento, string telefono) : base(nombre_apellido, dni, direccion, departamento, telefono)
        {
           
        }


        //Metodos
        public DataTable ConsultaDT()
        {
            return cn.ConsultarTablaClientes();
        }

        public override int Insertar(string nombre, string dni, string direccion, string departamento, string telefono)
        {

            int bandera;

            //Validacion DNI
            if (nombre != "" && dni != "" && telefono !="")
            {
                if ((dni.Length == 8 || dni.Length == 7))
                {
                    return cn.Insertar(nombre, dni, direccion, departamento, telefono);
                }
                else
                {
                    return bandera = 1;
                }


            }
            else
            {
                return bandera = 2;
            }

            
        }


        public override int Eliminar(string dni)
        {

            int bandera;

            //Validacion DNI
            if (dni != "" && ((dni.Length == 8 || dni.Length == 7)))
            {
              
                
              return cn.Eliminar(dni);
 
            }
            else
            {
                return bandera = 0;
            }

            
        }

        //Sin implentar
        public override int InsertarUsuario(string nombre, string dni, string direccion, string departamento, string telefono, string nick, string password)
        {
            throw new NotImplementedException();
        }

        public override int EliminarUsuario(string password,string dni)
        {
            throw new NotImplementedException();
        }
    }
}
