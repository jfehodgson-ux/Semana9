using System;

int[] puntajes = new int[6];
int mayoresde500 = 0;

for (int i = 0; i < puntajes.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese el puntaje de la partida {i + 1}:");
        puntajes[i] = int.Parse(Console.ReadLine()!);

        if (puntajes[i] > 500)
        {
            mayoresde500++;
        }
    }
    catch
    {
        Console.WriteLine($"Error: Ingrese un valor numérico para el puntaje de la partida {i + 1}.");
        i--;
    }
}

Console.WriteLine($"\nEl puntaje más alto es: {puntajes.Max()}");

Array.Sort(puntajes);

Console.WriteLine("\nPuntajes ordenados de menor a mayor:");

for (int i = 0; i < puntajes.Length; i++)
{
    Console.WriteLine($"Puntaje {i + 1}: {puntajes[i]}");
}

Console.WriteLine($"\nCantidad de puntajes mayores a 500: {mayoresde500}");