/*
5.
Dados dos arreglos ordenados de longitud m y n, implementa un programa en Java que encuentre e imprima los elementos comunes entre ambos arreglos.
*/

int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 6, 7, 3, 8, 9, 1, 5 };

for (int i = 0; i < array2.Length; i++)
{
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j] == array2[i])
        {
            Console.WriteLine(array1[j]);
        }
        else
        {
            continue;
        }
    }
}