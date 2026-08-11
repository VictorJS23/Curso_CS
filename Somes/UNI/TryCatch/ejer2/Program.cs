/*
Crea un array de string con un tamaño de 4, pero no asignes ningún valor a sus posiciones (por defecto, estarán en null). Luego, dentro de un bloque try, utiliza un bucle for para recorrer el array e la longitud de de la cadena de cada posición. El programa debe capturar la excepción y mostrar un mensaje como: "Error en la posición [i]: el elemento está vacío y no se puede medir".
*/

string[] array = new string[4];

try
{
    Console.WriteLine("Vamos a recorrer el Array");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i].Length);
    }
}
catch (NullReferenceException e)
{
    Console.WriteLine("Esto no se puede hacer porque: " + e.Message);
}