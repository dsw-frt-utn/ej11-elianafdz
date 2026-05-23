using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
   
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(60256, "Juan", 8);
        Alumno a2 = new Alumno(60734, "Eliana", 9);
        Alumno a3 = new Alumno(65693, "Lucas", 7);

        //Agregar 3 alumnos a la lista
        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("LISTA DE ALUMNOS");
        foreach (Alumno alumno in lista.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\nBUSCAR ELIANA");
        Alumno encontrado = lista.BuscarAlumno("Eliana");
        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBUSCAR CARLA");
        Alumno noExiste = lista.BuscarAlumno("Carla");
        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        //Eliminar un alumno y listar por consola los alumnos
        lista.EliminarAlumno(a2);
        Console.WriteLine("\nLISTA LUEGO DE ELIMINAR ELIANA");
        foreach (Alumno alumno in lista.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        lista.EliminarAlumnoPosicion(0);
        Console.WriteLine("\nLISTA FINAL LUEGO DE ELIMINAR EL PRIMER ALUMNO");
        foreach (Alumno alumno in lista.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }

 
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(60256, "Juan", 8);
        Alumno a2 = new Alumno(60734, "Eliana", 9);
        Alumno a3 = new Alumno(65693, "Lucas", 7);

        //Agregar 3 alumnos al diccionario
        diccionario.AgregarAlumno(a1);
        diccionario.AgregarAlumno(a2);
        diccionario.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("ALUMNOS EN DICCIONARIO");
        foreach (var item in diccionario.RetornarDiccionario())
        {
            Console.WriteLine(item.Value);
        }

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\nBUSCAR ID 60734");
        Alumno encontrado = diccionario.BuscarAlumno(60734);
        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBUSCAR ID 90567");
        Alumno noExiste = diccionario.BuscarAlumno(90567);
        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        //Eliminar un alumno por clave y listar por consola los alumnos
        diccionario.EliminarAlumno(65693);
        Console.WriteLine("\nDICCIONARIO FINAL LUEGO DE ELIMINAR 65693");
        foreach (var item in diccionario.RetornarDiccionario())
        {
            Console.WriteLine(item.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(linq.GetPrimero());

        Console.WriteLine("\nULTIMO LIBRO");
        Console.WriteLine(linq.GetUltimo());

        Console.WriteLine("\nTOTAL PRECIOS");
        Console.WriteLine(linq.GetTotalPrecios());

        Console.WriteLine("\nPROMEDIO PRECIOS");
        Console.WriteLine(linq.GetPromedioPrecios());

        Console.WriteLine("\nLIBROS ID > 15");
        foreach (Libro libro in linq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLIBROS FORMATEADOS");
        foreach (string libro in linq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nMAYOR PRECIO");
        Console.WriteLine(linq.GetMayorPrecio());

        Console.WriteLine("\nMENOR PRECIO");
        Console.WriteLine(linq.GetMenorPrecio());

        Console.WriteLine("\nMAYORES AL PROMEDIO");
        foreach (Libro libro in linq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nORDENADOS DESCENDENTE");
        foreach (Libro libro in linq.GetOrdenadosTitulo())
        {
            Console.WriteLine(libro);
        }
    }
}
