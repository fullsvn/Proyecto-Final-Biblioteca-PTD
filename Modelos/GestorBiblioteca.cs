using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class GestorBiblioteca
    {
        private List<Item> items;
        private List<Prestamo> prestamos;

        public GestorBiblioteca()
        {
            items = new List<Item>();
            prestamos = new List<Prestamo>();
        }
        public void AgregarItem(Item item)
        {
            items.Add(item);
        }

        public void EliminarItem(Item item)
        {
            items.Remove(item);
        }

        public void ListarItems()
        {
            Console.WriteLine("Catálogo de la Biblioteca:");
            foreach (Item item in items)
            {
                Console.WriteLine(item.ObtenerDescripcion());
            }
        }

        public void PrestarItem(Item item, string prestatario, DateTime fechaPrestamo)
        {
            if (item.EstadoDisponible())
            {
                item.EstadoPrestado(true);
                prestamos.Add(new Prestamo(item, prestatario, fechaPrestamo));
                Console.WriteLine($"Se prestó {item.ObtenerDescripcion()} a {prestatario}");
            }
            else
            {
                Console.WriteLine($"El item {item.ObtenerDescripcion()} no está disponible para préstamo.");
            }
        }

        public void DevolverItem(Item item)
        {
            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Item == item)
                {
                    item.EstadoPrestado(false);
                    prestamos.Remove(prestamo);
                    Console.WriteLine($"Se devolvió {item.ObtenerDescripcion()}");
                    return;
                }
            }
            Console.WriteLine($"El item {item.ObtenerDescripcion()} no se ha prestado.");
        }

        public void ListarPrestamos()
        {
            Console.WriteLine("Prestamos Activos:");
            foreach (Prestamo prestamo in prestamos)
            {
                Console.WriteLine($"Item: {prestamo.Item.ObtenerDescripcion()}, Prestatario: {prestamo.Prestatario}, Fecha de préstamo: {prestamo.FechaPrestamo.ToShortDateString()}");
            }
        }
    }
}
