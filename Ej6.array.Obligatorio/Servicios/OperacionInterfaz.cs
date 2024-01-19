using Ej6.array.Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6.array.Obligatorio.Servicios
{
    /// <summary>
    /// Interfaz que contiene el título de las operaciones de la aplicación.
    /// leig - 190124
    /// </summary>
    internal interface OperacionInterfaz
    { 
            /// <summary>
            /// Método que da de alta a los clientes.
            /// leig - 190124
            /// </summary>
            public void altaCliente(List<ClienteDtos> listaClientes);
            /// <summary>
            /// Método que ordena los clientes a partir de la edad.
            /// leig - 190124
            /// </summary>
            public void ordenarYContarClientes(List<ClienteDtos> listaClientes);
    }
}
