using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Armony
{
    class Habitaciones
    {
        private List<string> habitaciones = new List<string>();
        private List<bool> habitacionesOcupadas = new List<bool>();

        public Habitaciones(int cantidad)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                habitaciones.Add("Habitación " + i);
                habitacionesOcupadas.Add(false);
            }
        }

        public int CantidadHabitaciones()
        {
            return habitaciones.Count;
        }

        public string ObtenerEstado(int numeroHabitacion)
        {
            if (numeroHabitacion >= 1 && numeroHabitacion <= habitaciones.Count)
            {
                int index = numeroHabitacion - 1;
                return habitacionesOcupadas[index] ? "Ocupada" : "Desocupada";
            }
            else
            {
                return "Número de habitación no válido";
            }
        }

        public void CambiarEstado(int numeroHabitacion, bool ocupada)
        {
            if (numeroHabitacion >= 1 && numeroHabitacion <= habitaciones.Count)
            {
                int index = numeroHabitacion - 1;
                habitacionesOcupadas[index] = ocupada;
            }
            else
            {
                Console.WriteLine("Número de habitación no válido");
            }
        }

        public void MostrarHabitacionesDisponibles()
        {
            Console.WriteLine("Habitaciones Disponibles:");
            for (int i = 0; i < habitaciones.Count; i++)
            {
                if (!habitacionesOcupadas[i])
                {
                    Console.WriteLine(habitaciones[i] + " - Desocupada");
                }
            }
        }


        public void MostrarHabitacionesSeparadas()
        {
            Console.WriteLine("Habitaciones Separadas:");
            bool habitacionesSeparadas = false;

            for (int i = 1; i <= habitaciones.Count; i++)
            {
                if (ObtenerEstado(i) == "Ocupada")
                {
                    Console.WriteLine($"Habitación {i} - Ocupada");
                    habitacionesSeparadas = true;
                }
            }

            if (!habitacionesSeparadas)
            {
                Console.WriteLine("No hay habitaciones separadas.");
            }
        }


    }
}
