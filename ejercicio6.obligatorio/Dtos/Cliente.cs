using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6.obligatorio.Dtos
{
    internal class Cliente
    {

        long idCliente;

        string nombre;

        string apellidos;

        string nombreCompletoCliente;

        int edad;
        internal long id;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }


        public Cliente (long id, string nombre, string apellidos, string nombreCompletoCliente, int edad)
        {
            this.idCliente = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreCompletoCliente=nombreCompletoCliente;
            this.edad = edad;

        }

        public Cliente()
        {

        }

    }
}
