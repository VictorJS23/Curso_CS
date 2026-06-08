/*
Convertir de numero natural a romano
*/

/*
Convertir de numero natural a romano
*/

class Equivalencia
{
    public int[] numeros = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

    public string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    public string ConvertirARomano(int numero)
    {
        string resultado = "";

        for (int i = 0; i < numeros.Length; i++)
        {
            while (numero >= numeros[i])
            {
                resultado += romanos[i];
                numero -= numeros[i];
            }
        }

        return resultado;
    }
}

class Program
{
    static void Main()
    {
        Equivalencia valores = new Equivalencia();

        int numero = 75;

        string resultado = valores.ConvertirARomano(numero);

        Console.WriteLine($"El numero: {numero}, en romano es: {resultado}");
    }
}