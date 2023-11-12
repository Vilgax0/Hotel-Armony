using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Armony
{
    class Sistema : IMenu
    {
        public void MostrarOpciones()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Bienvenido al Hotel Armony Springs");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Ingresar datos del cliente");
            Console.WriteLine("2. Separar habitación");
            Console.WriteLine("3. Mostrar habitaciones separadas");
            Console.WriteLine("4. Salir");

        }


        public void ImprimirMenu()
        {

            MostrarOpciones();
        }
    }
}
