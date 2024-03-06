using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Cliente
    {
        private D_Cliente objd_Cliente = new D_Cliente();

        public List<Cliente> Listar()
        {
            return objd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario el No. de Documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario el Nombre Completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario el Correo del Cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es Necesario el Telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_Cliente.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario el No. de Documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario el Nombre Completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario el Correo del Cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es Necesario el Telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_Cliente.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objd_Cliente.Eliminar(obj, out Mensaje);
        }
    }

}
