// See https://aka.ms/new-console-template for more information
//Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada,
// donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, asumiendo una distancia
// fija de 40 kilómetros.
using System;

class Program

{
    static void Main(string[] arg)
    {
          //definir los datos del viaje 
        const Int distancia_fija = 40;
        Double Tiempo_total, Velocidad_precisa; 
        Console.WriteLine("calcular el tiempo total en horas de un viaje en bus");
        Console.WriteLine("Ingresar velocidad promedio");
        Velocidad_precisa = Convert.ToInt32(Console.ReadLine());
        
    //calcular el tiempo en kilometros mediante la siguiente formula
        Tiempo_Total = Distancia_fija/Velocidad_precisa;
        Console.WriteLine($"El resultado es:{TiempoT:F2} h");
        Console.ReadLine();
    }
        
}
    




