/*
6.
Dada una cadena de caracteres y un carácter específico, implementa un programa en Java que cuente el número de repeticiones de ese carácter en la cadena.
*/

char char1 = 'a';
string cadena = "aaabcdefga"; // 4 letras a

char[] array = cadena.ToCharArray();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == char1)
    {
        count++;
    }
}

Console.WriteLine($"El caracter '{char1}', se repite: {count} veces.");