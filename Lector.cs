/*
en c# y usando el bucle 'while' crea un Programa que lea notas y que termine con el valor -1.
Las notas deben estar incluidas en el rango que va de 0 al 10, descartando y avisando del error si no es una nota permitida.
La salida nos mostrará la cantidad de dieces que se han introducido.
*/

using System;

public class Program
{
    public static void Main()
    {
        int cantidadDieces = 0;

        Console.WriteLine("Introduce notas en el rango de 0 a 10. Ingresa -1 para finalizar.");
        
        while (true)
        {
            Console.Write("Introduce una nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota == -1)
            {
                break;
            }

            if (nota >= 0 && nota <= 10)
            {
                if (nota == 10)
                {
                    cantidadDieces++;
                }
            }
            else
            {
                Console.WriteLine("Error: La nota debe estar en el rango de 0 a 10.");
            }
        }

        Console.WriteLine($"Cantidad de dieces introducidos: {cantidadDieces}");
    }
}
