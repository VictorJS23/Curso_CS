/*
3.
Dadas dos cadenas de caracteres, implementa un programa en Java que determine si son anagramas, es decir, si contienen exactamente las mismas letras pero en un orden diferente.
El programa debe mostrar:
•	true si son anagramas
•	false en caso contrario
*/

Console.WriteLine("Ingrese 2 palabras para validar si son anagramas: ");
string word1 = Console.ReadLine();
string word2 = Console.ReadLine();

char[] array1 = word1.ToCharArray();
char[] array2 = word2.ToCharArray();

if (array1.Length != array2.Length)
{
    Console.WriteLine("Las palabras ingresadas no son anagramas1");
}
else
{
    Array.Sort(array1);
    Array.Sort(array2);

    bool flag = true;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            Console.WriteLine("Las palabras ingresadas no son anagramas2");
            flag = false;
            break;
        }
    }

    if (flag)
    {
        Console.WriteLine("Las palabras ingredas si son anagramas3");
    }
}