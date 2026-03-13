/*
Encontrar la secuencia creciente ininterrumpida más larga.
Implementa un método que encuentre la secuencia creciente más larga en un arreglo de números enteros. La secuencia creciente es una secuencia de números en la que cada número es mayor que el anterior.
Ejemplo:
Arreglo:
[1, 3, 2, 4, 8, 7, 9]
La secuencia creciente más larga sería:
2, 4, 8
Otro ejemplo:
[1, 3, 2, 4, 8, 7, 9, 11, 25, 200]
La secuencia más larga sería:
7, 9, 11, 25, 200
*/

int[] array = { 1, 3, 2, 4, 8, 7, 9 };

int[] secuency = [];

// int max = array.Length;

for (int i = 0; i <= array.Length; i++)
{
    if (array[i] < array[i + 1] && array[i + 2] > array[i + 1] && (array.Length - i) != -1)
    {
        secuency[i] = array[i];
    }
}

for (int i = 0; i < secuency.Length; i++)
{
    Console.Write(secuency[i] + " , ");
}

// aun le falta