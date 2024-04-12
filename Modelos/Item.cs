using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public abstract class Item
    {
        protected string titulo;
        protected string autor;
        protected int anoPublicacion;
        protected bool estaPrestado;

        public Item(string titulo, string autor, int anoPublicacion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacion = anoPublicacion;
            this.estaPrestado = false;
        }

        public abstract string ObtenerDescripcion();

        public bool EstadoDisponible()
        {
            return !estaPrestado;
        }

        public void EstadoPrestado(bool prestado)
        {
            estaPrestado = prestado;
        }
    }
}
