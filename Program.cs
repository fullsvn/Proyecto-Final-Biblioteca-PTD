using Biblioteca.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        GestorBiblioteca biblioteca = new GestorBiblioteca();

        Item libro1 = new Libro("C# Programming", "Juan Pérez", 2020);
        Item libro2 = new Libro("Introducción a los Algoritmos", "Thomas Cormen", 2009);
        Item revista1 = new Revista("National Geographic", "National Geographic Society", 2022);

        biblioteca.AgregarItem(libro1);
        biblioteca.AgregarItem(libro2);
        biblioteca.AgregarItem(revista1);

        biblioteca.ListarItems();

        Console.WriteLine("\n--- Prestamos ---");

        biblioteca.PrestarItem(libro1, "Alice", DateTime.Today);
        biblioteca.PrestarItem(libro2, "Bob", DateTime.Today.AddDays(-5));
        biblioteca.PrestarItem(revista1, "Charlie", DateTime.Today.AddDays(-10));

        biblioteca.ListarPrestamos();

        Console.WriteLine("\n--- Devoluciones ---");

        biblioteca.DevolverItem(libro1);
        biblioteca.DevolverItem(libro2);

        biblioteca.ListarPrestamos();
    }
}