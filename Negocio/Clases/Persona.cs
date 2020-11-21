using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public abstract class Persona
    {
        
        protected string nombre_apellido;
        protected string dni;
        protected string direccion;
        protected string departamento;
        protected string telefono;
        

        public Persona(string nombre, string dni, string direccion, string departamento, string telefono)
        {
            this.nombre_apellido = nombre;
            this.dni = dni;
            this.direccion = direccion;
            this.departamento = departamento;
            this.telefono = telefono;
        }

        

        public abstract int Insertar(string nombre, string dni, string direccion, string departamento, string telefono);

        public abstract int Eliminar(string dni);
        
        public abstract int InsertarUsuario(string nombre, string dni, string direccion, string departamento, string telefono, string nick, string password);

        public abstract int EliminarUsuario(string password,string dni); 
    }
}
