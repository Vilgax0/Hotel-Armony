using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Armony
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Contacto
        {
            get; set;

    public Cliente(string nombre, string contacto)
        {
            Nombre = nombre;
            Contacto = contacto;
        }

        public void MostrarDatosCliente()
        {
            Console.WriteLine("Nombre del cliente: " + Nombre);
            Console.WriteLine("Contacto del cliente: " + Contacto);
        }
    }
}
