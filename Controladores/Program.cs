using REPASO22012024.Dtos;
using REPASO22012024.Servicios;

namespace REPASO22012024.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fichero = @"C:\\Users\\profesor\\source\\repos\\REPASO22012024\\fichero\\text.txt";
            List<ClienteDtos> cliente  = new List<ClienteDtos>();
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            bool cerrarMenu = false;
            int opcionMenu, opcionMenuCliente, opcionMenuEmpleado;

            using (StreamWriter SW = new StreamWriter(fichero))
            {
                SW.WriteLine("Empieza la APP.");
            }

            while (!cerrarMenu)
            {
                opcionMenu = mi.menuPrincipal();
                using (StreamWriter SW = new StreamWriter(fichero, true))
                {
                    SW.WriteLine("Se ha abierto el menu principal");
                }

                switch (opcionMenu)
                {

                    case 0:

                        Console.WriteLine("[INFOS]- A continuacion se cerrara el menu.");
                        cerrarMenu = true;
                        using(StreamWriter sw = new StreamWriter(fichero, true))
                        {
                            sw.WriteLine("Se va a cerrar la aplicacion.");
                        }
                            break;

                    case 1:
                        using (StreamWriter sw = new StreamWriter(fichero, true))
                        {
                            sw.WriteLine("Se ejecuta la version del empleado y su menu.");
                        }
                        Console.WriteLine("VERSION EMPLEADO");
                        opcionMenuEmpleado = mi.menuEmpleado();
                        switch (opcionMenuEmpleado)
                        {
                            case 0:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 0. Volver");
                                }
                                Console.WriteLine("A continuacion se le redirigira al menu inicial.");
                                break;
                            case 1:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 1. Validar cliente");
                                }
                                ei.validarCliente(cliente);
                                break;
                            case 2:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 2. Borrar cliente");
                                }
                                ei.borrarCliente(cliente);
                                break;
                            case 3:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 3. Mostrar cliente validados");
                                }
                                foreach (ClienteDtos mostrar in cliente)
                                {
                                    Console.WriteLine(mostrar.ToString());
                                }
                                break;
                            default:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de ninguna opcion.");
                                }
                                Console.WriteLine("[INFOS]- No has escogido ninguna de las opciones seleccionada, a continuacion se le redirigira al menu inicial.");
                                break;

                        }
                        break;

                    case 2:
                        using (StreamWriter sw = new StreamWriter(fichero, true))
                        {
                            sw.WriteLine("Se ejecuta la version del cliente y su menu.");
                        }
                        Console.WriteLine("VERSION CLIENTE");
                        opcionMenuCliente = mi.menuCliente();
                        switch (opcionMenuCliente)
                        {
                            case 0:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 0. Volver");
                                }
                                Console.WriteLine("A continuacion se le redirigira al menu inicial.");
                                break;
                            case 1:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 1. Registrar cliente.");
                                }
                                ci.Registrocliente(cliente);
                                break;
                            case 2:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de la opcion 2. Login");
                                }
                                ci.accesoCliente(cliente);
                                break;
                            default:
                                using (StreamWriter sw = new StreamWriter(fichero, true))
                                {
                                    sw.WriteLine("Ejecucion de ninguna opcion.");
                                }
                                Console.WriteLine("[INFOS]- No has escogido ninguna de las opciones seleccionada, a continuacion se le redirigira al menu inicial.");
                                break;
                        }

                        break;

                    default:
                        using (StreamWriter sw = new StreamWriter(fichero, true))
                        {
                            sw.WriteLine("Ejecucion de ninguna opcion.");
                        }
                        Console.WriteLine("[INFOS]- No has escogido ninguna de las opciones seleccionada, vuelve a intentalo por favor.");
                        break;
                }
            }

            string lectura;
            using (StreamReader sr = new StreamReader(fichero))
            {
              lectura = sr.ReadToEnd();
            }
            Console.WriteLine(lectura.ToString()); 
        }
    }
}
