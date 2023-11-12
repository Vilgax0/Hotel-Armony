using System;
using Hotel_Armony;

class Program
{
    static void Main()
    {
        Hotel hotel = new Hotel("Armony Springs", "Circular 1 - Laureles", 5);
        Habitaciones habitaciones = new Habitaciones(10); // Suponiendo 10 habitaciones en el hotel
        Sistema sistema = new Sistema();

        int opcion;
        do
        {
            sistema.ImprimirMenu();
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del cliente:");
                        string nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el contacto del cliente:");
                        string contactoCliente = Console.ReadLine();
                        Cliente cliente = new Cliente(nombreCliente, contactoCliente);
                        cliente.MostrarDatosCliente();
                        break;
                    case 2:
                        Console.WriteLine("Habitaciones Disponibles:");
                        habitaciones.MostrarHabitacionesDisponibles();
                        Console.WriteLine("Ingrese el número de la habitación que desea separar:");
                        if (int.TryParse(Console.ReadLine(), out int numeroHabitacion))
                        {
                            if (numeroHabitacion >= 1 && numeroHabitacion <= habitaciones.CantidadHabitaciones())
                            {
                                habitaciones.CambiarEstado(numeroHabitacion, true);
                                Console.WriteLine("La habitación se ha separado con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("Número de habitación no válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case 3:
                        habitaciones.MostrarHabitacionesSeparadas();
                        break;
                        
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, elija una opción válida.");
            }
        } while (opcion != 4);
    }
}