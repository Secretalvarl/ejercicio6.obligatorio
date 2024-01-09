using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6.obligatorio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        
        public int menuYSeleccion()
        {
            int opcion;

            Console.WriteLine("------------------------------");
            Console.WriteLine("0. Cerrar menú");
            Console.WriteLine("1. Dar de alta nuevo cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("------------------------------");

            opcion = Convert.ToInt32(Console.ReadLine());


            return opcion;
   
        }

    }
}
