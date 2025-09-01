// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Programa para saber si un numero es positvo, negativo o cero");
Console.WriteLine("ingrese un numero" );
num=Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("numero positivo");
}
else if (num == 0)
{
    Console.WriteLine("numero igual a cero");
}
else
{
    Console.WriteLine("numero negativo");
}