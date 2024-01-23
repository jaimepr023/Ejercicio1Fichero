using REPASO22012024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO22012024.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void borrarCliente(List<ClienteDtos> listaCliente)
        {
            Console.WriteLine("¿Que usuario quieres eliminar? Decidelo por su DNI.");
            string dni = Console.ReadLine();

            foreach (var cliente in listaCliente)
            {
                if (cliente.DniCliente.Equals(dni))
                {
                    listaCliente.Remove(cliente);
                }
            }
        }

        public void validarCliente(List<ClienteDtos> listaCliente)
        {
            foreach (var cliente in listaCliente)
            {
                if (cliente.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\" + "\n" +
                 "DNI--> " + cliente.DniCliente + "\n" +
                 "Nombre--> " + cliente.NombreCompletoCliente + "\n" +
                  "\\\\\\\\\\" + "\n");
                }

                Console.WriteLine("¿Que usuario quieres validar? Decidelo por su DNI.");
                string dni = Console.ReadLine();

                if (cliente.DniCliente.Equals(dni))
                {
                    cliente.EsValidado = true;
                }

            }
        }


    }



       
    
}
