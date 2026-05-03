/*
Programa en C# solicita tres números enteros y los ordena de mayor a menor, indicando
cuál es el mayor, el central y el menor.

Programa en C# solicita tres números enteros y muestra cuál de ellos es el mayor
*/

//--------------------SIN ARRAYS------------------------------------>>

Console.WriteLine("Ingrese un numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro numero: ");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Los numeros ingresados fueron: {num1}, {num2}, {num3}");

if (num1 < num2)
{
    int aux = num1;
    num1 = num2;
    num2 = aux;
}

if (num1 < num3)
{
    int aux = num1;
    num1 = num3;
    num3 = aux;
}

if (num2 < num3)
{
    int aux = num2;
    num2 = num3;
    num3 = aux;
}

Console.WriteLine($"Los numeros ordenados son: {num1}, {num2}, {num3}");
Console.WriteLine($"Mayor: {num1}, Central: {num2}, Menor: {num3}");

//--------------------CON ARRAYS------------------------------------>>

System.Console.WriteLine("------------------------ARRAYS---------------------------");

int[] array = new int[3]; //Length es el numero de posiciones osea 3
// 1, 2, 3
// 0, 1, 2

// Lectura de datos
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Ingrese un numero: ");
    array[i] = int.Parse(Console.ReadLine());
}

// Ordenamiento de los datos, Metodo BubbleSort o ordenamiento de burbuja
for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        int aux = 0;
        if (array[i] < array[j])
        {
            aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
    }
}

Console.WriteLine($"Mayor: {array[0]}, Central: {array[1]}, Menor: {array[2]}");

//array = {1, 2, 3}

//array = {3,  2,  1}
//        {0},{1},{2}