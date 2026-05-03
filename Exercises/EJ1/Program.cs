/*
Implementa un programa en Java que calcule la secuencia de Collatz para un número entero positivo dado. La secuencia de Collatz se obtiene siguiendo las siguientes reglas: si el número es par, se divide por 2; si es impar, se multiplica por 3 y se le suma 1. El proceso se repite hasta llegar a 1.
Aquí hay un ejemplo de la sucesión de Collatz para el número 6:
Para el número 6, la secuencia de Collatz sería:
•	6 -> 3 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
Comenzamos con el número 6. Como es par, lo dividimos por 2 y obtenemos 3. Como 3 es impar, lo multiplicamos por 3 y le sumamos 1, obteniendo 10. Continuamos aplicando las reglas de la sucesión de Collatz hasta que llegamos al número 1, que marca el final de la secuencia.
*/

Console.Write("Enter a number for vefication: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(number);

while (number != 1)
{
    if (number % 2 == 0)
    {
        number = number / 2;
        Console.WriteLine(number);
    }
    else if (number % 2 != 0)
    {
        number = (number * 3) + 1;
        Console.WriteLine(number);
    }
}