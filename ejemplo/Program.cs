// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa para saber si un numero es positivo, negativo o 0");
int num;
Console.WriteLine("Ingrese un numero entero");
num = Convert.ToInt32(Console.ReadLine()); //Esto es para leer los datos que ingrese el usuario
//Primero lo convertimos a int, ya que lo lee en string
if (num > 0)
{
    Console.WriteLine("EL numero es positivo");
}
else if (num < 0)
{
    Console.WriteLine("EL numero es negativo");
}
else
{
    Console.WriteLine("EL numero es 0");
}
