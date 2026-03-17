/*
9.
Calcular binomio al cuadrado (a+b)²
*/

// Ejemplo (x+3)^2

string formule(int n, string x)
{
    return $"({x}^2 + {n + n}{x} + {Math.Pow(n, 2)})";
}

string x = "x";
int n = 3;

Console.WriteLine("El resultado de la ecuacion es: " + formule(n, x));