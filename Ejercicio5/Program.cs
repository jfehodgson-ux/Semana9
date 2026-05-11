using System;

int[] notas = new int[8];
int suma = 0;
int reprobados = 0;

for (int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
        notas[i] = Convert.ToInt32(Console.ReadLine()!);

        suma += notas[i];

        if (notas[i] < 60)
        {
            reprobados++;
        }
    }
    catch
    {
        Console.WriteLine($"Error: Ingrese un valor numérico para la nota del estudiante {i + 1}.");
        i--;
    }
}

Console.WriteLine("\nNotas aprobadas:");

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 60)
    {
        Console.WriteLine($"Estudiante {i + 1}: {notas[i]}");
    }
}

int promedio = suma / notas.Length;

Console.WriteLine($"\nCantidad de estudiantes reprobados: {reprobados}");

Console.WriteLine($"\nEl promedio general del grupo es: {promedio}");