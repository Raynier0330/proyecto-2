using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Usuario
    {
        private D_Usuario objd_usuario = new D_Usuario();

        public List<Usuario> Listar()
        {
            return objd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario el Nombre Completo del Usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es Necesario la Clave del Usuario\n";
            }

            if(Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_usuario.Registrar(obj, out Mensaje);
            }
            
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario el Nombre Completo del Usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es Necesario la Clave del Usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_usuario.Editar(obj, out Mensaje);
            }
            
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
