using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Proveedor
    {
        private D_Proveedor objd_Proveedor = new D_Proveedor();

        public List<Proveedor> Listar()
        {
            return objd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario el Documento del Proveedor\n";
            }

            if (obj.Razon == "")
            {
                Mensaje += "Es Necesario la Razon del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario el correo del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_Proveedor.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario el Documento del Proveedor\n";
            }

            if (obj.Razon == "")
            {
                Mensaje += "Es Necesario la Razon del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario el correo del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_Proveedor.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
