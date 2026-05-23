using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;


public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();

    //Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    //Incluir un método para retornar la lista
    public List<Alumno> RetornarLista()
    {
        return alumnos;
    }

    //Incluir un método para buscar un alumno por nombre
    public Alumno BuscarAlumno(string nombre)
    {
        foreach (Alumno alumno in alumnos)
        {
            if (alumno.Nombre == nombre)
            {
                return alumno;
            }
        }
        return null;
    }

    //Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    //Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoPosicion(int posicion)
    {
        alumnos.RemoveAt(posicion);
    }
}