/*
 * Hacer un programa que imprima lo siguente:
 * +
 * ++
 * +++
 * ++++
 * +++++
 * -> Debe de ser un metodo que le solucite al usuario el simbolo, la letra o
 * numero a imprimir y el tamaño de la piramide. =>

 */

char symbol = '0';
int cantidad = 6;

// Creciente
for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine(new string(symbol, i));
}
Console.WriteLine("-----------------------");
// Decreciente
for (int i = cantidad; i > 0; i--)
{
    Console.WriteLine(new string(symbol, i));
}