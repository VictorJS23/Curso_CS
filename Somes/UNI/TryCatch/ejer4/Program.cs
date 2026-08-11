/*
Ejercicio 2: Crea un programa que tenga un array con 5 notas numéricas (por ejemplo, 
double[] notas = { 80, 95, 72, 100, 68 };). Pide al usuario que ingrese el número de la nota que desea consultar (un número del 1 al 5). Muestra la nota correspondiente. Si el usuario ingresa un número incorrecto, captura la IndexOutOfRangeException y 
muéstrale un mensaje amigable como: "Ha seleccionado una nota que no existe. Por 
favor, elija un número del 1 al 5.".
*/

int[] notas = { 80, 95, 72, 100, 68 };

bool flag = true;

while (flag)
{
    try
    {
        Console.WriteLine("Ingrese un numero de la nota para verla:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"La nota correspondiente al numero ingresado '{num}', es: {notas[num]}");

        flag = false;
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("Numero no valido, Debe ser un numero de entre 0 a 4 !!!");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Este programa solo acepta numeros !!!");
        Console.WriteLine("Aqui paso que: " + e.Message);
    }
    catch (OverflowException e)
    {
        Console.WriteLine("El numero ingresado es demasiado grande, intentalo otra vez !!");
    }
}