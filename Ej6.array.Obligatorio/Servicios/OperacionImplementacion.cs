using Ej6.array.Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6.array.Obligatorio.Servicios
{

    /// <summary>
    /// Método que desarrolla la lógica de las operaciones de la aplicación.
    /// leig - 190124
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        private ClienteDtos crearNuevoCliente()
        {
            long id;
            string nombre;
            string apellidos;
            int edad;

            Console.WriteLine("Introduzca su id");
            id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su apellido");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            ClienteDtos añadirClientes = new ClienteDtos(id, nombre, apellidos, edad);
            return añadirClientes;
        }

        public void altaCliente(List<ClienteDtos> listaClientes)
        {
            ClienteDtos añadirClientes = crearNuevoCliente();
            listaClientes.Add(añadirClientes);

        }

        public void ordenarYContarClientes(List<ClienteDtos> listaClientes)
        {
            if (listaClientes.Count >= 3)
            {
                Console.WriteLine("Clientes sin ordenar:");
                foreach (var clientes in listaClientes)
                {
                    Console.WriteLine(clientes.ToString());
                }

                Console.WriteLine("---------------");
                Console.WriteLine("Clientes ya ordenados:");
                for (int i = 0; i < listaClientes.Count - 1; i++)
                {
                    for (int j = 0; j < listaClientes.Count - 1 - i; j++)
                    {
                        if (listaClientes[j].Edad > listaClientes[j + 1].Edad)
                        {
                            int aux = listaClientes[j].Edad;
                            listaClientes[j].Edad = listaClientes[j + 1].Edad;
                            listaClientes[j + 1].Edad = aux;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Para iniciar la aplicación debe tener mínimo 3 clientes registrados");
            }
        }
    }
}
