

using System;
double promedio = 0;
double [] temperaturas = new double[7];


for (int i = 0; i < temperaturas.Length; i++)
{
    try
    {
        Console.WriteLine("Ingrese la temperatura del día " + (i + 1) + ":");
        temperaturas[i] = double.Parse(Console.ReadLine()!);
        promedio += temperaturas[i];
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal.");
        i--;
    }

}

Console.WriteLine("Las temperaturas registradas son:");
for (int i = 0; i < temperaturas.Length; i++)
{
    Console.WriteLine ($"\nTemperatura del dia {i + 1}: {temperaturas[i]}"); 

}

promedio = promedio / 7;
Console.WriteLine($"\nEl promedio semanal es: {promedio:F2}");

Console.WriteLine($"\nLa temperatura más alta es: {temperaturas.Max()}");
Console.WriteLine($"\nLa temperatura más baja es: {temperaturas.Min()}");