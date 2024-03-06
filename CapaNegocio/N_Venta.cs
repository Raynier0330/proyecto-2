using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Venta
    {
        private D_Venta objd_venta = new D_Venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objd_venta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objd_venta.ObtenerCorrelativo();
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta oVenta = objd_venta.ObtenerVenta(numero);

            if(oVenta.IdVenta != 0)
            {
                List<Detalle_Venta> oDetalleVenta = objd_venta.ObtenerDetalleVenta(oVenta.IdVenta);
                oVenta.objDetalleVenta = oDetalleVenta;
            }
            return oVenta;
        }
    }
}
