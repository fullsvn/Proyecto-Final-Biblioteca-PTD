using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class Prestamo
    {
        public Item Item { get; }
        public string Prestatario { get; }
        public DateTime FechaPrestamo { get; }

        public Prestamo(Item item, string prestatario, DateTime fechaPrestamo)
        {
            Item = item;
            Prestatario = prestatario;
            FechaPrestamo = fechaPrestamo;
        }
    }
}
