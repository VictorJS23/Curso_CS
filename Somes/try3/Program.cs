/*
Programa en C# calcula un incentivo para un empleado basado en el número de hijos que
tiene. Solicita el sueldo y el número de hijos del empleado, y si el empleado tiene hijos, le
asigna un incentivo de 500 por cada hijo. Luego, muestra el sueldo, el número de hijos y el
incentivo calculado
*/

Console.WriteLine("Ingrese su sueldo");
double sueldo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de hijos que tiene: ");
int hijos = int.Parse(Console.ReadLine()); // 2

double incentivo = 500 * hijos;
incentivo += sueldo;

Console.WriteLine($"El sueldo sin incentivo es de: {sueldo}");
Console.WriteLine($"La cantidad de hijos es de: {hijos}");
Console.WriteLine($"El sueldo con incentivo calculado es de: {incentivo}");