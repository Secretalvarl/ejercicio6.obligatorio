using ejercicio6.obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6.obligatorio.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo para agregar un nuevo cliente a la lista
        /// </summary>
        /// agarera - 13/01/2024
        /// <param name="listaAntigua"></param>
        public void agregarCliente(List<Cliente> listaAntigua);

        /// <summary>
        /// Metodo privado que solicita toda la informacion  al usuario
        /// </summary>
        /// agarera - 13/01/2024
        /// <param name="listaAntigua"></param>
        public void ordenarEdad(List<Cliente> listaAntigua);

    }
}
