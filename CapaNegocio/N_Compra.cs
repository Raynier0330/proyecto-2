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
    public class N_Compra
    {
        private D_Compra objd_compra = new D_Compra();

        public int ObtenerCorrelativo()
        {
            return objd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = objd_compra.ObtenerCompra(numero);

            if(oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = objd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.objDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }
    }
}
