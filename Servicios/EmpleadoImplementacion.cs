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

            if (listaCliente.Count > 0)
            {
                //Asi no da ningun error al haber 0 celdas en la fila
                ClienteDtos clienteAux = new ClienteDtos();
                foreach (var cliente in listaCliente)
                {
                    if (cliente.DniCliente.Equals(dni))
                    {
                        //Porque tiene la misma referencia.
                        clienteAux = cliente;
                    }
                }
                listaCliente.Remove(clienteAux);
                Console.WriteLine("El usuario con DNI: " + dni + "ha sido borrado");
            }
            
        }

        public void validarCliente(List<ClienteDtos> listaCliente)
        {
            Console.WriteLine("Clientes no validos");
            List<ClienteDtos> listaAuxiliar = new List<ClienteDtos>();
            foreach (var cliente in listaCliente)
            {
                if (cliente.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\" + "\n" +
                                      "DNI--> " + cliente.DniCliente + "\n" +
                                      "Nombre--> " + cliente.NombreCompletoCliente + "\n" +
                                      "\\\\\\\\\\" + "\n");
                    listaAuxiliar.Add(cliente);
                }

                //esta condicion solo sirve si en la lista auxiliar qeu es donde se guardan los clientes no validados hay gente y entra y hace el metodo o no
                if (listaAuxiliar.Count > 0)
                {
                    Console.WriteLine("¿Que usuario quieres validar? Decidelo por su DNI.");
                    string dni = Console.ReadLine();

                    if (cliente.DniCliente.Equals(dni))
                    {
                        cliente.EsValidado = true;
                        Console.WriteLine("El usuario con DNI: " + dni + "ha sido validado");
                    }
                }
               

            }
        }


    }



       
    
}
