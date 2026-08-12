Console.WriteLine("Bienvenido a la calculadora!!!");
Console.WriteLine("Acontinuacion, Ingrese dos numeros para comenzar a operar: ");
Console.WriteLine("");

double num1, num2;

while (true)
{
    try
    {
        System.Console.Write("Ingrese el primer numero: ");
        num1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("");
        System.Console.Write("Ingrese el segundo numero: ");
        num2 = double.Parse(Console.ReadLine());
        break;
    }
    catch (FormatException e)
    {
        Console.WriteLine("Formato no valido, solo se permiten numeros, intentado otra vez");
    }
}

bool flag = true;

do
{
    Console.WriteLine("Ingrese la Operacion que desea realizar: ");
    System.Console.WriteLine(" + , Para sumar.");
    System.Console.WriteLine(" - , Para Restar.");
    System.Console.WriteLine(" * , Para Multiplicar.");
    System.Console.WriteLine(" / , Para Dividir.");

    string opcion = "";

    try
    {
        opcion = Console.ReadLine();
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Formato no valido, solo se permiten los simbolos (+, -, * , /)");
    }

    switch (opcion)
    {
        case "+":
            double suma = num1 + num2;
            System.Console.WriteLine("La suma de los numeros es de: " + suma);
            flag = false;
            break;

        case "-":
            double resta = num1 - num2;
            System.Console.WriteLine("La resta de los numeros es de: " + resta);
            flag = false;
            break;

        case "*":
            double multi = num1 * num2;
            System.Console.WriteLine("La multiplicacion de los numeros es de: " + multi);
            flag = false;
            break;

        case "/":
            try
            {
                double div = num1 / num2;
                System.Console.WriteLine("La division de los numeros es de: " + div);
                flag = false;
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("No se puede dividir por cero !!!");
            }
            break;

        default:
            System.Console.WriteLine("El simbolo ingresado no es valido, intentalo otra vez");
            break;
    }

} while (flag);