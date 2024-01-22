using REPASO22012024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO22012024.Servicios
{
    internal interface ClienteInterfaz
    {
        public void Registrocliente(List<ClienteDtos> listaCliente);

        public void accesoCliente(List<ClienteDtos> listaCliente);
    }
}
