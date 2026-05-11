
using System;

decimal ventastotal = 0;
decimal [] ventasdia = new decimal [7];
int diasuperior150 = 0;

for ( int i = 0; i < ventasdia.Length; i++ )
{
 try
    {
        Console.WriteLine($"Ingrese la ventas del dia {i + 1}:");
        ventasdia[i] = Convert.ToDecimal(Console.ReadLine()!);
        ventastotal += ventasdia[i];

        if (ventasdia[i] > 150)
        {
            diasuperior150++;
        }
    }  
  catch
    {
        Console.WriteLine($"Error: Ingrese un valor numérico para las ventas del dia {i + 1}.");
        i--; 
    }   

}

Console.WriteLine($"El total vendido en la semana es: {ventastotal}");

Console.WriteLine($"Días con ventas superiores a 150: {diasuperior150}");

Console.WriteLine($"La venta más baja registrada es: {ventasdia.Min()}");