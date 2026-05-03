// Programa en C# verifica si un número entero ingresado por el usuario es par o impar.

Console.Write("Ingrese un numero: ");
int num = int.Parse(Console.ReadLine());

string result = num % 2 == 0 ? "Es par" : "Es impar";

Console.WriteLine(result);