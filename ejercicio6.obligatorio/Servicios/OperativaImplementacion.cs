using ejercicio6.obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6.obligatorio.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        /// <summary>
        /// Metodo para agregar un nuevo cliente a la lista 
        /// </summary>
        /// agarera - 13/01/2024
        /// <param name="listaAntigua"></param>
        public void agregarCliente(List<Cliente> listaAntigua)
        {
            // Crea u nuevo cliente con la informacion dada por el usuario
            Cliente cliente = crearNuevoCliente();

            // agrega un nuevo cliente
            listaAntigua.Add(cliente);

        }
        /// <summary>
        /// Metodo privado que solicita toda la informacion  al usuario
        /// </summary>
        /// agarera - 13/01/2024
        /// <returns></returns>
        private Cliente crearNuevoCliente()
        {
            //Solicita al usuario todos los datos para añadir un cliente
            Cliente nuevoCliente = new Cliente();

            Console.WriteLine("Escriba el id");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Escriba su nombre");
            nuevoCliente.Nombre = Console.ReadLine();

            Console.WriteLine("Escriba sus apellidos");
            nuevoCliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Escriba la edad");
            nuevoCliente.Edad = Convert.ToInt32(Console.ReadLine());

            return nuevoCliente;

        }
        /// <summary>
        /// Metodo para ordenar los clientes por edades
        /// </summary>
        /// agarera - 13/01/2024
        /// <param name="listaAntigua"></param>
        public void ordenarEdad(List<Cliente> listaAntigua)
        {

            int edades = listaAntigua.Count;

            // // Ordena la lista por edad usando el algoritmo de Burbuja
            if (listaAntigua.Count >= 3)
            {
                // Bucle anidado para recorrer toda la lista
                for (int filas = 0; filas < listaAntigua.Count; filas++)
                {
                    for (int columnas = 0; columnas < listaAntigua.Count - 1 - filas; columnas++)
                    {
                        // Intercambia las posiciones entre clientes dependiendo de la edad que tengan
                        if (listaAntigua[columnas +1].Edad > listaAntigua[columnas].Edad)
                        {
                            Cliente aux = listaAntigua[columnas + 1];
                            listaAntigua[columnas + 1] = listaAntigua[columnas];
                            listaAntigua[columnas] = aux;

                            
                        }
                        
                    }
                }
                Console.WriteLine("Estos son los clientes ordenados de forma descendente");

                // Muestra la lista de clientes ordenada
                foreach (Cliente cliente in listaAntigua)
                {
                    Console.WriteLine(cliente.ToString());
                }
                
            }
            else
            {
                Console.WriteLine("Debe añadir minimo 3 usuarios para poder ordenarlos");
            }
            
        }

        

    }
}
