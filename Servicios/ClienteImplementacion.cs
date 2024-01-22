using REPASO22012024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO22012024.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    { 
        private ClienteDtos crearCliente(List<ClienteDtos> listaCliente)
        {
            ClienteDtos clienteNuevo = new ClienteDtos();
            Console.WriteLine("Dame el DNI suyo para guardarlo.");
            clienteNuevo.DniCliente = Console.ReadLine();

            Console.WriteLine("Dame su nombre completo con el formato especifico(nombre<ESPACIO>apellido<ESPACIO>apelldio).");
            clienteNuevo.NombreCompletoCliente = Console.ReadLine();

            Console.WriteLine("Dame su email para guardarlo.");
            clienteNuevo.EmailCliente = Console.ReadLine();

            Console.WriteLine("Refistrese con una contraseña y acuerdese muy bien para recordarla mas tarde.");
            clienteNuevo.ContraseniaCliente = Console.ReadLine();

            separarCadena(clienteNuevo);
            añadirid(clienteNuevo, listaCliente);

            return clienteNuevo;
        }

        private void añadirid(ClienteDtos cliente, List<ClienteDtos> listaCliente)
        {
            foreach (var item in listaCliente)
            {
                cliente.IdCliente =item.IdCliente+1;
            }
        }

        private void separarCadena(ClienteDtos clienteNuevo)
        {
            char caracter = ' ' ;
            string[] todo = clienteNuevo.NombreCompletoCliente.Split(caracter) ;
            clienteNuevo.NombreCliente = todo[0];
            clienteNuevo.Apellido1Cliente = todo[1];
            clienteNuevo.Apellido2Cliente = todo[2];
        }




        public void Registrocliente(List<ClienteDtos> listaCliente)
        {
            ClienteDtos cliente = crearCliente(listaCliente);
            listaCliente.Add(cliente);
        }

        public void accesoCliente(List<ClienteDtos> listaCliente)
        {
            Console.WriteLine("Dame su email y contraseña para validar que es el usuario correspondiente");
            Console.Write("Email--> ");
                string email = Console.ReadLine();
            Console.Write("Contraseña--> ");
            string contra = Console.ReadLine();

            foreach (var item in listaCliente) 
            {
                if(item.EmailCliente.Equals(email) & item.ContraseniaCliente.Equals(contra) & item.EsValidado == true)
                {
                    Console.WriteLine("\"INICIO DE SESIÓN CORRECTO\".");
                }else if(item.EmailCliente.Equals(email) & item.ContraseniaCliente.Equals(contra) & item.EsValidado == false)
                {
                    Console.WriteLine("\"INICIO DE SESIÓN ERRONEO(No esta validado el cliente)\".");
                }
                else
                {
                    Console.WriteLine("\"INICIO DE SESIÓN ERRONEO\".");
                }
            }
        }
    }
}
