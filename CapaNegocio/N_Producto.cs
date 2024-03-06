using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Producto
    {
        private D_Producto objd_Producto = new D_Producto();

        public List<Producto> Listar()
        {
            return objd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es Necesario el Codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es Necesario el Nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es Necesaria la Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_Producto.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es Necesario el Codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es Necesario el Nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es Necesaria la Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_Producto.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
