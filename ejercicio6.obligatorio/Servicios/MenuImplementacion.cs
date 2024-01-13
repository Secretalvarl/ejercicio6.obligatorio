using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6.obligatorio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y la seleccion de usuario
        /// </summary>
        /// agarera - 13/01/2024  
        /// <returns></returns>
        public int menuYSeleccion()
        {
            int opcion;

            // Muestra las opciones del menu
            Console.WriteLine("------------------------------");
            Console.WriteLine("0. Cerrar menú");
            Console.WriteLine("1. Dar de alta nuevo cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("------------------------------");
            // Recoge la seleccion del usuario
            opcion = Convert.ToInt32(Console.ReadLine());


            return opcion;
   
        }

    }
}
