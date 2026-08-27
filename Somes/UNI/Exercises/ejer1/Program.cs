public class Program
{
    static void Main(String[] args)
    {
        bool flag = true;
        int num = 0;

        do
        {
            bool flag2 = true;

            while (flag2)
            {
                try
                {
                    Console.WriteLine("Bienvenido al conversor de temperaturas !!!");
                    Console.WriteLine("1. Convertir de Fahrenheit a Celsius.");
                    Console.WriteLine("2. Convertir de Celsius a Fahrenheit.");
                    num = int.Parse(Console.ReadLine()!);
                    flag2 = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo se permiten numeros, intentelo nuevamente. \n");
                }
            }

            switch (num)
            {
                case 1:
                    bool flag3 = true;
                    while (flag3)
                    {
                        try
                        {
                            Console.Write("Ingrese la temperatura en Fahrenheit: ");
                            double fahrenheit = double.Parse(Console.ReadLine()!);
                            Temperatura Fahrenheit = new Temperatura(fahrenheit);
                            double convercion = Fahrenheit.ConvertirACelsius(fahrenheit);
                            Fahrenheit.MostrarResultadoFTC(convercion);
                            flag = false;
                            flag3 = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Solo se permiten numeros, intentelo nuevamente. \n");
                        }
                    }
                    break;

                case 2:
                    bool flag4 = true;
                    while (flag4)
                    {
                        try
                        {
                            Console.Write("Ingrese la temperatura en Celcius: ");
                            double celsius = double.Parse(Console.ReadLine()!);
                            Temperatura Celsius = new Temperatura(celsius, true);
                            double conversion = Celsius.ConvertirAFahrenheit(celsius);
                            Celsius.MostrarResultadoCTF(conversion);
                            flag = false;
                            flag4 = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Solo se permiten numeros, intentelo nuevamente. \n");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Ninguna de las entradas fue valida !!!");
                    break;

            }

        } while (flag);

    }
}