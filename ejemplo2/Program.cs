// See https://aka.ms/new-console-template for more information
//Desarrolle un programa que calcule el monto total a pagar por la compra de una cantidad específica
// de un producto, donde el precio por unidad se proporciona como una variable de entrada desconocida 
//ingresada por el usuario.

int cantidad;

double precioUnitario, montoTotal;

Console.WriteLine("Ingrese el precio por unidad del producto:");

precioUnitario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de productos a comprar:");

cantidad = Convert.ToInt32(Console.ReadLine());

montoTotal = cantidad * precioUnitario;

Console.WriteLine($"El monto total a pagar por {cantidad} productos es:{montoTotal:C}");
Console.ReadLine();
