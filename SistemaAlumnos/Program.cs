using SistemaAlumnos;

Alumno alumno1 = new Alumno();
alumno1.Nombre = "Sara";
alumno1.Legajo = 22;
alumno1.Nota1 = 8;
alumno1.Nota2 = 10;

Alumno alumno2 = new Alumno();
alumno2.Nombre = "Bautista";
alumno2.Legajo = 24;
alumno2.Nota1 = 7;
alumno2.Nota2 = 9;

Console.WriteLine($"{alumno1.Nombre} --- {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} --- {alumno2.Legajo}");

alumno1.Nombre = "Emma";

Console.WriteLine($"{alumno1.Nombre} --- {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} --- {alumno2.Legajo}");
