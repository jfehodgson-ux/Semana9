
using System;

double [,] matriz = new double [3,3];

Console.WriteLine("Matrices");
Console.WriteLine("Ingresa las temperaturas");
int cont = 1;


for (int r = 0; r < 3 ; r++)
{
    for (int c = 0; c < 3 ; c++)
    {   try
        {
        Console.WriteLine ($"Dime la temperatura # {cont++}");
        matriz[r,c] = Convert.ToDouble(Console.ReadLine()!);
        }
        catch
        {
        Console.WriteLine("Error, validacion no pasada, porfavor un valor correspondiente");
        cont --;
        c --;
            
        }
    }
}

Console.Clear();

Console.WriteLine("Temperaturas registradas");
for (int f = 0; f < 3; f++ )

{
    for (int c = 0 ; c < 3; c++)

    {   if(matriz[f,c] >=40) 
        {Console.ForegroundColor =ConsoleColor.Red;
        Console.Write($"{matriz[f,c]} ");
        Console.ResetColor();
        }
        else if (matriz[f,c] >=35) 
        {
        Console.ForegroundColor =ConsoleColor.Yellow;
        Console.Write($"{matriz[f,c]} ");
        Console.ResetColor();
        }
        else if (matriz[f,c] <=34) 
        {
        Console.ForegroundColor =ConsoleColor.Green;
        Console.Write($"{matriz[f,c]} ");
        Console.ResetColor();
        }
    }
    Console.WriteLine();
    Console.ResetColor();
}

