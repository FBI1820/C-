// See https://aka.ms/new-console-template for more information
//Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular en una finca
// nicaragüense, donde el usuario ingresa la longitud y el ancho en varas (1 manzana = 1,428.8 varas²),
// utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada

using System;

class Program
{
    static void Main(string[] arg)
    {
    const int Ancho = 5;
    Int Longitud;
    Double AreaM, AreaV;
    const Double Varas_manzana = 1428.8; 
    //AreaM= Area en manzanas, AreaV= Area en varas y varas_manzana= Factor de conversion en varas 
        Console.WriteLine("Calcular el area total de la finca nicaragüense");
        //definir los datos de la finca 
    Console.WriteLine("Ingresar longitud:");
    Longitud=Convert.ToInt32(Console.ReadLine());
  
        //Formula para calcular el area en varas mediante la siguiente formula
    AreaV = (double)Longitud * Ancho;
    Console.WriteLine($"El resultado es:{AreaV:F2} varas²");
    //Luego calcular el area en manzanas 
    AreaM = AreaV/Varas_manzana;
    Console.WriteLine($"El resultado es:{AreaM:F2} manzanas");
    Console.ReadLine();
    }
}
    
    


