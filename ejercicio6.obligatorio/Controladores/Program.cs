using ejercicio6.obligatorio.Dtos;
using ejercicio6.obligatorio.Servicios;

namespace ejercicio6.obligatorio.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lista para almacenar los clientes
            List<Cliente> listaClientes = new List<Cliente>();

            // Instancias de las interfaces
            MenuInterfaz alpha = new MenuImplementacion();
            OperativaInterfaz omega = new OperativaImplementacion();

            bool cerrarMenu = false;

            int opcionSeleccionada;

            // Bucle principal del menú
            while (!cerrarMenu) 
            {
                // Muestra el menú y obtiene la selección del usuario
                opcionSeleccionada = alpha.menuYSeleccion();

                // Evalúa la opción seleccionada
                switch (opcionSeleccionada)
                {
                    // Cierra el menú
                    case 0:
                        cerrarMenu |= true;
                        Console.WriteLine("Menu cerrado");
                        break;
                    // Agrega un nuevo cliente 
                    case 1:
                        Console.WriteLine("Dar alta cliente");
                        omega.agregarCliente(listaClientes);
                        break;
                    // Ordena la lista de clientes por edad si la opción es 2
                    case 2:
                        omega.ordenarEdad(listaClientes);
                        
                        break;
                }
            }


        }
    }
}