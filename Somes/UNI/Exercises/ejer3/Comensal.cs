public class Comensal
{
    private string nombre = "";
    private double consumo;
    private double propinaConsumo = 0;
    private double ConsumoConPropina = 0;

    public Comensal(string nombre, double consumo)
    {
        this.nombre = nombre;
        this.consumo = consumo;
    }

    public void AgregarConsumo(double ValorConsumo)
    {
        consumo += ValorConsumo;
    }

    public double MostrarConsumo()
    {
        return consumo;
    }

    public void SetPropinaCliente(double consumo)
    {
        propinaConsumo = consumo;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public double GetPropinaConsumo()
    {
        return propinaConsumo;
    }

    public double GetTotalPropinaConsumo()
    {
        ConsumoConPropina = consumo + propinaConsumo;
        return ConsumoConPropina;
    }
}