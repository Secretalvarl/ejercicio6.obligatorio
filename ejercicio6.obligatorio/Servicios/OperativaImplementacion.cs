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
        public void agregarCliente(List<Cliente> listaAntigua)
        {
            Cliente cliente = crearNuevoCliente();

            listaAntigua.Add(cliente);

        }

        private Cliente crearNuevoCliente()
        {
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



    }
}
