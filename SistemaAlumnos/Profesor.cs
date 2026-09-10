namespace SistemaAlumnos;

public class Profesor : Persona
{
    public string Materia { get; private set; }
    
    public Profesor(string nombre, int documento, string materia) : base(nombre, documento)
    {
        Materia = materia;
    }
    public override string ToString()
    {
        return $"{Nombre} (Doc. {Documento}) - Materia: {Materia}";
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} y dicto {Materia}";
    }
}