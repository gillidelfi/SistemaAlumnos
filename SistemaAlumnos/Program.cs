using SistemaAlumnos;

Alumno alumno1 = new Alumno("Sara",22);

Alumno alumno2 = new Alumno("Bautista", 24);

Console.WriteLine($"{alumno1.Nombre} --- {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} --- {alumno2.Legajo}");

alumno1.Nombre = "Emma";
// alumno1.Nota1 = 47; ya no compila porque Nota1 esta en private set


Console.WriteLine($"{alumno1.Nombre} --- {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} --- {alumno2.Legajo}");

// Cargar notas antes del promedio
alumno1.CargarNotas(5, 8);
alumno2.CargarNotas(7, 9);

Console.WriteLine($"{alumno1.Nombre} - Promedio: {alumno1.Promedio()} - Aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} - Promedio: { alumno2.Promedio()} - Aprobado: {alumno2.EstaAprobado()}");

// Prueba subirNota()
alumno2.SubirNota();
Console.WriteLine($"Después de SubirNota : {alumno2.Nombre} - Nota1: {alumno2.Nota1} - Nota2: {alumno2.Nota2} - Promedio: {alumno2.Promedio()} - Aprobado: {alumno2.EstaAprobado()}");

Alumno alumnoTope = new Alumno("Sofía", 103);
alumnoTope.SubirNota();
Console.WriteLine($"{alumnoTope.Nombre} - Nota1: {alumnoTope.Nota1} - Nota2: {alumnoTope.Nota2}");

/* ejemplo de error: Alumno alumno3 = new Alumno();
 salida por consola:0>Program.cs(14,22): Error CS7036 : No se ha dado ningún argumento que corresponda al parámetro requerido "nombre" de "Alumno.Alumno(string, int, decimal, decimal)"
   0>------- Finished building project: SistemaAlumnos. Succeeded: False. Errors: 1. Warnings: 0
   Build completed in 00:00:03.343 
   explicacion: una vez que se crea un constructor personalizado, el constructor por defecto ya no funciona. Por eso new Alumno() sin argumentos ya no compila: le falta lo que el constructor exige.*/

bool CargaNota = alumno1.CargarNotas(5, 22);

if (CargaNota)
{
    Console.WriteLine("Notas cargadas correctamente");
}
else
{
    Console.WriteLine("Notas inválidas: no fueron cargadas ");
}
