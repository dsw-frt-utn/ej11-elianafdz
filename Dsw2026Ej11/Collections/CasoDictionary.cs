using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno

public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno BuscarAlumno(int id)
    {
        if (alumnos.ContainsKey(id))
        {
            return alumnos[id];
        }
        return null;
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return alumnos;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int id)
    {
        alumnos.Remove(id);
    }
}