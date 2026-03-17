/*
10.
Hacer un programa que determine cual es un año bisiesto
*/

Console.Write("Verificar si es biciesto: ");
int year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("si es bisiesto");
}
else
{
    Console.WriteLine("no es bisiesto");
}