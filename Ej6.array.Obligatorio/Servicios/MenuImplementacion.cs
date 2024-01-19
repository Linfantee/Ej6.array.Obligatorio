using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6.array.Obligatorio.Servicios
{
    /// <summary>
    /// Método que desarrolla la lógica del menú de la aplicación.
    /// leig - 190124
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {

            int eleccionUsuario;

            Console.WriteLine("---------------");
            Console.WriteLine("0. Cerrar menú.");
            Console.WriteLine("1. Dar de alta a un nuevo cliente.");
            Console.WriteLine("2. Ordenar la lista de clientes.");   
            Console.WriteLine("---------------");

            eleccionUsuario = Console.ReadKey(true).KeyChar - ('0');
            return eleccionUsuario;
        }
    }
}
