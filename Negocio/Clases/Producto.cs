using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Producto
    {
        //Atributos
       DataProducto cn = new DataProducto(); //asociacion
       private string nombreProducto;
       private string codigoProducto;
       private string stock;
       private string pCosto;
       private string pVenta;

        public Producto(string nombreProducto, string codigoProducto, string stock, string pCosto, string pVenta)
        {
            this.nombreProducto = nombreProducto;
            this.codigoProducto = codigoProducto;
            this.stock = stock;
            this.pCosto = pCosto;
            this.pVenta = pVenta;
        }



        //Metodos

        public DataTable ConsultaDTInv()
        {
            return cn.ConsultarTablaInventario();
        }

        public int InsertarProducto()
        {
            int bandera;
            //Validacion
            if (nombreProducto!="" && codigoProducto!="" && stock!="" && pCosto != "" && pVenta!="")
            {
                return cn.InsertarProducto(codigoProducto,nombreProducto,stock,pCosto,pVenta);

            }
            else
            {
                return bandera = 2;
            }

            
        }

        public int EliminarProducto()
        {
            int bandera;

            if (codigoProducto != "")
            {
                return cn.EliminarProducto(codigoProducto);

            }
            else
            {
                return bandera = 2;
            }


           
        }
    }
}
