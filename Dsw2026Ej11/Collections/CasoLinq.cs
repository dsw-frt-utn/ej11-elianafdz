using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

 //Para cada punto crear un método que permita los puntos que se piden
 //En todos los casos debe aplicarse LINQ
 
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();

    //  1. Obtener el primer libro (GetPrimero)
    public Libro GetPrimero()
    {
        return libros.First();
    }

    // 2. Obtener el último libro (GetUltimo)
    public Libro GetUltimo()
    {
        return libros.Last();
    }

    // 3. Obtener la suma de precios (GetTotalPrecios)
    public decimal GetTotalPrecios()
    {
        return libros.Sum(x => x.Precio);
    }

    // 4. Obtener el promedio de precios (GetPromedioPrecios)
    public decimal GetPromedioPrecios()
    {
        return libros.Average(x => x.Precio);
    }

    //  5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro> GetListById()
    {
        return libros.Where(x => x.Id > 15).ToList();
    }

    //  6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        return libros
            .Select(x => $"{x.Titulo} - {x.Precio:C}")
            .ToList();
    }

    // 7. Obtener el libro con el precio más alto (GetMayorPrecio)
    public Libro GetMayorPrecio()
    {
        return libros.OrderByDescending(x => x.Precio).First();
    }

    // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
    public Libro GetMenorPrecio()
    {
        return libros.OrderBy(x => x.Precio).First();
    }

    //  9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = libros.Average(x => x.Precio);
                return libros
            .Where(x => x.Precio > promedio)
            .ToList();
    }

    // 10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> GetOrdenadosTitulo()
    {
        return libros
            .OrderByDescending(x => x.Titulo)
            .ToList();
    }
}