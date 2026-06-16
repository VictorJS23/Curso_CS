/*
Pares de suma igual.
Dado un arreglo unidimensional de números enteros y un valor objetivo, encuentra todos los pares de elementos en el arreglo cuya suma sea igual al valor objetivo.
*/

int[] numeros = { 4, 7, 2, 8, 5, 1, 9, 3, 6, 0 };
int objetivo = 9;

List<string> resultado = new();

for (int i = 0; i < numeros.Length; i++)
{
    for (int j = i + 1; j < numeros.Length; j++)
    {
        if (numeros[i] + numeros[j] == objetivo)
        {
            resultado.Add($"({numeros[i]}, {numeros[j]})");
        }
    }
}

foreach (string item in resultado)
{
    Console.WriteLine(item);
}