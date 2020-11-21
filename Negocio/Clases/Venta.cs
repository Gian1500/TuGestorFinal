using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Venta
    {
        //Atributos
        DataVenta cn = new DataVenta();
        public double totalVenta = 0;
        public int stockanterior = 0;
        public DateTime fecha;
        public string departamento;
        public string entrega;
        public string cantidad;
        public string codigo;

        //Metodos

        public Venta(string codigo, string cantidad)
        {
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.stockanterior = cn.TraerStock(this.codigo);
            Entrega entrega1 = new Entrega(fecha,departamento,entrega);

        }

        public DataTable ConsultaDTVentas()
        {
            return cn.ConsultarTablaVentas();
        }
       

        public int ActualizarStock(string codigo, int stockNuevo)
        {

            stockNuevo = Convert.ToInt32(stockanterior) - Convert.ToInt32(cantidad); 

            return cn.ActualizarStock(codigo, stockNuevo);
        }

        public double consultaVenta(string codigo)
        {
            

            return cn.consultaVenta(codigo);
        }

        public string consultaProducto(string codigo)
        {

           return cn.consultaProducto(codigo);
    
        }

        public double calcularTotal()
        {
            double bandera;

            if(cantidad== "" && codigo == "")
            {
               return bandera = -1;
            }
            else
            {
                return totalVenta = cn.consultaVenta(codigo) * Convert.ToInt32(cantidad);
            }

        }

       
    }
}
