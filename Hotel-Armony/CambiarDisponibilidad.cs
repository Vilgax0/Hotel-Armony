using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Armony
{
    class CambiarDisponibilidad
    {
        public void CambiarEstadoHabitacion(Habitaciones habitaciones, int numeroHabitacion, bool ocupada)
        {
            habitaciones.CambiarEstado(numeroHabitacion, ocupada);
        }
    }
}
