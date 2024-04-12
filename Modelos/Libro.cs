using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class Libro : Item
    {
        public Libro(string titulo, string autor, int anoPublicacion) : base(titulo, autor, anoPublicacion)
        {
        }
        public override string ObtenerDescripcion()
        {
            return $"Libro: {titulo} por {autor}, publicado en {anoPublicacion}";
        }
    }
}
