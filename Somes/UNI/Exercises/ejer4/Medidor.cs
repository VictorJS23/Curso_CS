public class Medidor
{
    private static int contadorMedidor = 0;
    private string IdMedidor = "";
    private double lecturaActual;
    private double lecturaAnterior;
    private double consumo = 0;

    public Medidor(double lecturaActual, double lecturaAnterior)
    {
        this.lecturaActual = lecturaActual;
        this.lecturaAnterior = lecturaAnterior;

        contadorMedidor++;
        IdMedidor = "M" + contadorMedidor.ToString("D4");
    }

    public void CalcularConsumo()
    {
        consumo = lecturaActual - lecturaAnterior;
    }

    public double GetConsumo()
    {
        return consumo;
    }

    public string GetIdMedidor()
    {
        return IdMedidor;
    }

    public double GetAnterior()
    {
        return lecturaAnterior;
    }

    public double GetActual()
    {
        return lecturaActual;
    }
}