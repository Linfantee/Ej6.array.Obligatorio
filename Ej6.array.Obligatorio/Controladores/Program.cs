using Ej6.array.Obligatorio.Dtos;
using Ej6.array.Obligatorio.Servicios;
namespace Ej6.array.Obligatorio;

/// <summary>
/// Clase principal de la aplicación.
/// leig - 190124
/// </summary>
class Program
{
    /// <summary>
    /// Método principal que contiene el procediento de la aplicación.
    /// leig - 190124
    /// </summary>
    public static void Main(string[] args)
    {

        List<ClienteDtos> listaClientes = new List<ClienteDtos>();

        MenuInterfaz mi = new MenuImplementacion();
        OperacionInterfaz oi = new OperacionImplementacion();

        bool cerrarMenu = false;
        int seleccionUsuario;

        while (!cerrarMenu)
        {
            seleccionUsuario = mi.mostrarMenuYSeleccion();

            switch (seleccionUsuario)
            {
                case 0:
                    Console.WriteLine("Se ha cerrado la aplicación.");
                    cerrarMenu = true;
                    break;
                case 1:
                    Console.WriteLine("Has seleccionado la opción de dar de alta a un nuevo cliente.");
                    oi.altaCliente(listaClientes);

                    break;
                case 2:
                    oi.ordenarYContarClientes(listaClientes);
                    Console.WriteLine("Has seleccionado la opción de ordenar la lista de los clientes.");
                    foreach (var clientes in listaClientes)
                    {
                        Console.WriteLine(clientes);
                    }
                    break;

            }

        }

    } 

}

