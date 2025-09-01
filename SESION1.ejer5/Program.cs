// See https://aka.ms/new-console-template for more information
//Desarrolle un programa que calcule la cantidad total de baldes de leche producida en un día en una lechería
// de Estelí, utilizando como entradas el volumen promedio por vaca en litros y el número total de vacas ordeñadas
// ambos proporcionados por el usuario (1 balde = 20 litros).

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir la constante de la capacidad de un balde
        const double litros_por_balde = 20.0;
        
        // Declarar las variables para las entradas y el resultado
        double volumen_promedio_vaca;
        double numero_vacas;
        double volumen_total_litros;
        double cantidad_total_baldes;

        Console.WriteLine("Calcular la cantidad total de baldes de leche producida en la lechería");
        
        // Solicitar y leer el volumen promedio por vaca
        Console.WriteLine("Ingresa el volumen promedio de leche por vaca (en litros):");
       volumen_Promedio_Vaca = Convert.ToDouble(Console.ReadLine());

        // Solicitar y leer el número total de vacas
        Console.WriteLine("Ingresa el número total de vacas ordeñadas:");
        numero_vacas= Convert.ToDouble(Console.ReadLine());

        // Calcular el volumen total de leche en litros
        volumen_promedio_vaca= volumen_promedio_vaca *numero_vacas;

        // Calcular la cantidad total de baldes dividiendo el volumen total entre 20
        cantidad_total_baldes = volumen_total_litros / litros_por_balde;

        // Mostrar el resultado con dos decimales
        Console.WriteLine($"La cantidad total de baldes de leche producida es: {cantidad_total_baldes:F2} baldes.");
        
        Console.ReadLine();
    }
}
