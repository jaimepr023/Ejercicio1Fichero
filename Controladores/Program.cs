using REPASO22012024.Dtos;
using REPASO22012024.Servicios;

namespace REPASO22012024.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ClienteDtos> cliente  = new List<ClienteDtos>();
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            bool cerrarMenu = false;
            int opcionMenu, opcionMenuCliente, opcionMenuEmpleado;
           
            while(!cerrarMenu)
            {
                opcionMenu = mi.menuPrincipal();
                switch(opcionMenu)
                {
                    case 0:
                        Console.WriteLine("[INFOS]- A continuacion se cerrara el menu.");
                        cerrarMenu=true;
                        break;

                    case 1:
                        opcionMenuEmpleado = mi.menuEmpleado();
                        switch (opcionMenuEmpleado)
                        {
                            case 0:
                                Console.WriteLine("A continuacion se le redirigira al menu inicial.");
                                break;
                            case 1:
                                ei.validarCliente(cliente);
                                break;
                            case 2:
                                ei.borrarCliente(cliente);
                                break;
                            case 3:
                               foreach(ClienteDtos mostrar in cliente)
                                {
                                    Console.WriteLine(mostrar.ToString());
                                }
                                break;
                            default:
                                Console.WriteLine("[INFOS]- No has escogido ninguna de las opciones seleccionada, a continuacion se le redirigira al menu inicial.");
                                break;

                        }
                        break;

                    case 2:
                        opcionMenuCliente = mi.menuCliente();
                        switch (opcionMenuCliente)
                        {
                            case 0:
                                Console.WriteLine("A continuacion se le redirigira al menu inicial.");
                                break;
                            case 1:
                                ci.Registrocliente(cliente);
                                break;
                            case 2:
                               ci.accesoCliente(cliente);
                                break;
                            default:
                                Console.WriteLine("[INFOS]- No has escogido ninguna de las opciones seleccionada, a continuacion se le redirigira al menu inicial.");
                                break;
                        }
                        
                        break;

                    default:
                        Console.WriteLine("[INFOS]- No has escogido ninguna de las opciones seleccionada, vuelve a intentalo por favor.");
                        break;
                }
            }

        }
    }
}
