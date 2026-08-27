public class Temperatura
{
    private double Fahrenheit;
    private double Celsius;

    public Temperatura(double Fahrenheit)
    {
        if (Fahrenheit < -459.67) Fahrenheit = -459.67;
        this.Fahrenheit = Fahrenheit;
    }

    public Temperatura(double Celsius, bool esCelsius)
    {
        if (Celsius < -273.15) Celsius = -273.15;
        this.Celsius = Celsius;
    }

    public double ConvertirACelsius(double Fahrenheit)
    {
        Celsius = (Fahrenheit - 32) * 5 / 9;
        return Celsius;
    }

    public double ConvertirAFahrenheit(double Celsius)
    {
        Fahrenheit = (Celsius * 9 / 5) + 32;
        return Fahrenheit;
    }

    public void MostrarResultadoFTC(double C)
    {
        Console.WriteLine($"La temperatura en Fahrenheit ingresada: {this.Fahrenheit}");
        Console.WriteLine($"Su valor en Celsius es de: {C}");
    }

    public void MostrarResultadoCTF(double F)
    {
        Console.WriteLine($"La temperatura en Celsius ingresada: {this.Celsius}");
        Console.WriteLine($"Su valor en Fahrenheit es de: {F}");
    }

}