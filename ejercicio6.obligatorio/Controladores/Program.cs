using ejercicio6.obligatorio.Dtos;
using ejercicio6.obligatorio.Servicios;

namespace ejercicio6.obligatorio.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>();

            MenuInterfaz alpha = new MenuImplementacion();
            OperativaInterfaz omega = new OperativaImplementacion();

            bool cerrarMenu = false;

            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = alpha.menuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu |= true;
                        Console.WriteLine("Menu cerrado");
                        break;
                    case 1:
                        Console.WriteLine("Dar alta cliente");
                        omega.agregarCliente(listaClientes);
                        break;
                    case 2:

                        break;
                }
            }


        }
    }
}