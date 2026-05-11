using System;

int[] ventaslibros = new int[5];
int totalventas = 0;

for (int i = 0; i < ventaslibros.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la cantidad de libros vendidos en la categoría {i + 1}:");
        ventaslibros[i] = Convert.ToInt32(Console.ReadLine()!);

        totalventas += ventaslibros[i];
    }
    catch
    {
        Console.WriteLine($"Error: Ingrese un valor numérico para la categoría {i + 1}.");
        i--;
    }
}

double promedio = (double)totalventas / 5;

Console.WriteLine($"\nEl total de libros vendidos es: {totalventas}");

Console.WriteLine($"\nLa categoría con más ventas registró: {ventaslibros.Max()} libros");

Console.WriteLine($"\nEl promedio de ventas es: {promedio:F2}");