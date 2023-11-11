using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Armony
{
    class Hotel
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Categoria { get; set; }

        public Hotel(string nombre, string direccion, int categoria)
        {
            Nombre = nombre;
            Direccion = direccion;
            Categoria = categoria;
        }
    }
}