// See https://aka.ms/new-console-template for more information
//Desarrolle un programa que calcule el volumen total en metros cúbicos de agua recolectada en un tanque
// en una finca de Masaya, utilizando como entradas la longitud, el ancho y la altura del tanque
//, todos proporcionados por el usuario.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Declarar las variables como tipo double para aceptar valores con decimales
        Double Longitud, Ancho, Altura;
        Double Volumentotal;

        Console.WriteLine("Calcular el volumen de agua en un tanque  m³");
        
        // Solicitar y leer la longitud
        Console.WriteLine("Ingresa la longitud del tanque en M:");
        Longitud = Convert.ToDouble(Console.ReadLine());

        // Solicitar y leer el ancho
        Console.WriteLine("Ingresa el ancho del tanque en M:");
        Ancho = Convert.ToDouble(Console.ReadLine());

        // Solicitar y leer la altura
        Console.WriteLine("Ingresa la altura del tanque en M:");
        Altura = Convert.ToDouble(Console.ReadLine());

        // Calcular el volumen total usando la fórmula
        Volumentotal =Longitud*Ancho*Altura;

        // Mostrar el resultado formateado a dos decimales
        Console.WriteLine($"El volumen total de agua es: {Volumentotal:F2} m³");
        Console.ReadLine();
    }
}

