namespace SistemaAlumnos;

public class Alumno
{
    public string Nombre { get; set; }
    public int Legajo { get; private set; }
    public decimal Nota1 { get; private set; }
    public decimal Nota2 { get; private set; }

    public Alumno(string nombre, int legajo) //metodo constructor 
    {
        Nombre = nombre; 
        Legajo = legajo;
    }

    public decimal Promedio()
    {
        return (Nota1 + Nota2) / 2;
    }

    public bool EstaAprobado()
    {
        return Promedio() >= 6; 
    }

    public void SubirNota()
    {
        Nota1 += 1;
        if (Nota1 > 10)
        {
            Nota1 = 10;
        }

        Nota2 += 1;
        if (Nota2 > 10)
        {
            Nota2 = 10;
        }
    }

    public override string ToString()
    {
        return $" {Legajo} -  {Nombre} - {Promedio()}";
    }

    public bool CargarNotas(decimal nota1, decimal nota2)
    {
        if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            return false; // si las notas no se encuentran en el rango, devuelve false 
        }

        Nota1 = nota1;
        Nota2 = nota2;
        return true; // si se encuentran, las asigna y devuelve true 
    }
    }
    /* mensaje al sacar override: Warning CS0114 : 'Alumno.ToString()' oculta el miembro heredado 'object.ToString()'. Para hacer que el miembro actual invalide esa implementación, agregue la palabra clave override. Si no, agregue la palabra clave new.
       SistemaAlumnos -> /Users/delfinagilli/RiderProjects/SistemaAlumnos/SistemaAlumnos/bin/Debug/net10.0/SistemaAlumnos.dll
       0>------- Finished building project: SistemaAlumnos. Succeeded: True. Errors: 0. Warnings: 1*/
