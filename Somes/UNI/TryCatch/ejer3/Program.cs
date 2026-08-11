/*
Ejercicio 1: Solicita al usuario que ingrese un número de día de la semana (del 1 al 7). Ten un array de string con los siete nombres de los días ("Lunes", "Martes", etc.). Intenta mostrar el nombre del día correspondiente al número ingresado. Tu programa debe manejar el caso en que el usuario ingrese un número fuera del rango válido (ej: 0, 8, -2) y mostrar el mensaje: "Error: El número del día debe estar entre 1 y 7.". (Pista: recuerda que los índices del array van de 0 a 6).
*/

string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

bool flag = true;

while (flag)
{
    try
    {
        Console.WriteLine("Ingrese un numero de dia para verlo:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"El dia correspondiente al numero ingresado '{num}', es: {dias[num]}");

        flag = false;
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("Numero no valido, Debe ser un numero de entre 1 a 7 !!!");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Este programa solo acepta numeros !!!");
    }
}