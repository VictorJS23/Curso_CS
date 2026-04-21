/*
Cree un menu interactivo donde el usuario ingrese 2 numeros y permita elegir
entre sumar, restar, dividir o multiplicar
*/

Console.WriteLine("Bienvenido a la calculadora, Ingrese 2 numeros: ");
Console.Write("Numero 1: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Numero 2: ");
double num2 = double.Parse(Console.ReadLine());

bool flag = true;

do
{
    Console.WriteLine("Elija 0. para sumar.");
    Console.WriteLine("Elija 1. para restar.");
    Console.WriteLine("Elija 2. para multiplicar.");
    Console.WriteLine("Elija 3. para Dividir.");
    Console.WriteLine("Elija 4. para Salir.");
    Console.Write("Ingrese la Opcion: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 0:
            double suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} + {num2} es: {suma}");
            flag = false;
            break;
        case 1:
            double resta = num1 - num2;
            Console.WriteLine($"La resta de {num1} - {num2} es: {resta}");
            flag = false;
            break;
        case 2:
            double mult = num1 * num2;
            Console.WriteLine($"La Multiplicacion de {num1} * {num2} es: {mult}");
            flag = false;
            break;
        case 3:
            double div = num1 / num2;
            Console.WriteLine($"La Division de {num1} / {num2} es: {div}");
            flag = false;
            break;
        case 4:
            Console.WriteLine("Gracias por usar la calculadora!!");
            flag = false;
            break;
        default:
            Console.WriteLine("La Opcion ingresa no fue valida, intentelo otra vez!!");
            break;
    }
} while (flag);