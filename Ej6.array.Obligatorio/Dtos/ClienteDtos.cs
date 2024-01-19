using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6.array.Obligatorio.Dtos
{
    /// <summary>
    /// Clase donde se guardan los métodos de atributos del cliemte.
    /// leig - 190124
    /// </summary>
    internal class ClienteDtos
    {
        long idCliente;
        string nombreCliente;
        string apellidosCliente;
        string nombreCompletoCliente;
        int edad;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        public ClienteDtos(long idCliente, string nombreCliente, string apellidosCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente + " " + apellidosCliente;
            this.edad = edad;
        }
 
        override
        public string ToString()
        {
            string cliente =
            "Nombre completo: " + this.nombreCompletoCliente +
            " Edad: " + this.edad;

            return cliente;

        }
    }
}
