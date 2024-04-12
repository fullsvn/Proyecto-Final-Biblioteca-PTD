using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    internal class Revista : Item
    {
        public Revista(string titulo, string autor, int anoPublicacion) : base(titulo, autor, anoPublicacion)
        {
        }

        public override string ObtenerDescripcion()
        {
            return $"Revista: {titulo}, por {autor}, publicada en {anoPublicacion}";
        }
    }
}
