using SistemaAlumnos;

Alumno alumno1 = new Alumno("Sara", 47765376, 22);

Alumno alumno2 = new Alumno("Bautista", 48798209, 24);

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

Alumno alumnoTope = new Alumno("Sofía", 47639854, 103);
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
//ETAPA 6: 

List<Alumno> alumnos = new List<Alumno>();
int opcion;
bool opcionValida;

do
{
    Console.WriteLine(" MENU DE OPCIONES");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por legajo");
    Console.WriteLine("4. Promedio general del curso");
    Console.WriteLine("5. Cantidad de alumnos aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elegí una opción: ");
    
    opcion = int.Parse( Console.ReadLine());
    opcionValida = opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4  || opcion == 5 || opcion == 6;
    if (!opcionValida)
    {
        Console.WriteLine("Opción inválida. Intente de nuevo.");

    }
    switch (opcion)
    {
        case 1:
            AgregarAlumno(alumnos);
            break;
        case 2:
            ListarAlumnos(alumnos);
            break;
        case 3:
            BuscarAlumno(alumnos);
            break;
        case 4:
            PromedioGeneral(alumnos);
            break;
        case 5:
            CantidadAprobados(alumnos);
            break;
        default:
            Console.WriteLine("Opción inválida. Elegí un número del 1 al 6.");
            break;
    }
} while (opcion != 6);
void AgregarAlumno(List<Alumno> lista)
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    
    Console.Write("Documento: ");
    int documento = int.Parse(Console.ReadLine());

    Console.Write("Legajo: ");
    int legajo = int.Parse(Console.ReadLine());
    
    Console.Write("Nota 1: ");
    decimal nota1 = decimal.Parse(Console.ReadLine());

    Console.Write("Nota 2: ");
    decimal nota2 = decimal.Parse(Console.ReadLine());
    
    Alumno nuevo = new Alumno(nombre, documento, legajo);
    lista.Add(nuevo);
    Console.WriteLine("Alumno agregado.");
    
    bool notacargada = nuevo.CargarNotas(nota1, nota2);
    if (!notacargada)
    {
        Console.WriteLine("Las notas deben estar entre 0 y 10. Se agregó el alumno sin notas cargadas.");
    }
}

void ListarAlumnos(List<Alumno> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("No hay Alumnos cargados.");
        return;
    }

    foreach (Alumno a in lista)
    {
        Console.WriteLine(a.ToString());
    }
}

void BuscarAlumno(List<Alumno> lista)
{
    Console.Write("Ingrese el legajo del alumno: ");
    int legajo = int.Parse(Console.ReadLine());

    Alumno encontrado = null;
    foreach (Alumno a in lista)
    {
        if (a.Legajo == legajo)
        {
            encontrado = a;
            break; 
        }
    }
    if (encontrado == null)
    {
        Console.WriteLine("No se encontraron alumnos con ese legajo.");
    }
    else
    {
        Console.WriteLine(encontrado.ToString());
    }
        
}

void PromedioGeneral(List<Alumno> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("No hay alumnos cargados todavía.");
        return;
    }
    decimal suma = 0;
    foreach (Alumno a in lista)
    {
       suma += a.Promedio(); 
    }
    decimal promedioGeneral = suma / lista.Count;
    Console.WriteLine($"El promedio general del curso: {promedioGeneral}");
}

void CantidadAprobados(List<Alumno> lista)
{
    int aprobados = 0;
    foreach (Alumno a in lista)
    {
        if (a.EstaAprobado())
        {
            aprobados++; 
        }
    }
    Console.WriteLine($"Cantidad de alumnos aprobados: {aprobados}");
}


//prueba profesor: 
Profesor profesor1 = new Profesor("Marta Ruiz", 25873492, "historia");
Console.WriteLine(profesor1.ToString()); 

Preceptor preceptor1 = new Preceptor("Julio Gómez", 30111222, "tarde");

List<Persona> personas = new List<Persona>();
personas.Add(alumno1);
personas.Add(alumno2);
personas.Add(profesor1);
personas.Add(preceptor1);


foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Presentarse());
}
