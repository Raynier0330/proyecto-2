using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Permiso
    {
        private D_Permiso objd_permiso = new D_Permiso();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objd_permiso.Listar(IdUsuario);
        }
    }
}
