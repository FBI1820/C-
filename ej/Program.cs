// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa que permite calcular la suma independiente de los numero pares e impares entre el 1 al 100");
int i;
int sumaPares, sumaImpares =0;
for (i = 1; i <= 100; i = i + 2)
{
    sumaPares = sumaPares + i;
    Console.WriteLine("La suma de los numeros pares es: " + sumaPares);
}
for (i = 1; i <= 100; i = i + 2)
{
    sumaImpares = sumaImpares + i;
    Console.WriteLine("La suma de los numeros impares es: " + sumaImpares);
}
for (i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sumaPares += i;
        Console.WriteLine("La suma de los numeros pares es: " + sumaPares);
    }
    else
    {
        sumaImpares += i;
        Console.WriteLine("La suma de los numeros impares es: " + sumaImpares);
    }
}
