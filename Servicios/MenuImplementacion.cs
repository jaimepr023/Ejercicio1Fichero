using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO22012024.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuCliente()
        {
            int opcion;
            Console.WriteLine("Elija una opcion de utilidad en relacion con el cliente.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Opcion 0. Volver a la ventana anterior");
            Console.WriteLine("Opcion 1. Registro cliente.");
            Console.WriteLine("Opcion 2. Acceso cliente (Login).");
            Console.WriteLine("-------------------------------");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;

        }

        public int menuEmpleado()
        {
            int opcion;
            Console.WriteLine("Elija una opcion de utilidad en relacion con el empleado.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Opcion 0. Volver a la ventana anterior");
            Console.WriteLine("Opcion 1. Validar cliente");
            Console.WriteLine("Opcion 2. Borrado de cliente");
            Console.WriteLine("Opcion 3. Mostrar cliente");
            Console.WriteLine("-------------------------------");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuPrincipal()
        {
            int opcion;
            Console.WriteLine("Elija una opcion de entrada.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Opcion 0. Cerrar menu.");
            Console.WriteLine("Opcion 1. Version empleado.");
            Console.WriteLine("Opcion 2. Version cliente.");
            Console.WriteLine("-------------------------------");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
