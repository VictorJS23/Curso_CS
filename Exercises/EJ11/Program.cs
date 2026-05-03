// Recibe 5 numeros y ordenalos

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Ingrese un numero en la posicion " + (i + 1) + ": ");
    array[i] = int.Parse(Console.ReadLine());
}

//Ordenar el arreglo
//BubbleSort

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        int aux = 0;
        if (array[i] > array[j])
        {
            aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
    }
}

Console.WriteLine();
Console.WriteLine("El arreglo ordenado es: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(" | " + array[i] + " | ");
}

