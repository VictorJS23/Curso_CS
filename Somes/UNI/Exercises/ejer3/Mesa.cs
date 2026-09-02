public class Mesa
{
    public Mesa()
    {
        contadorMesa++;
        IdMesa = contadorMesa.ToString("D4");
    }

    private string IdMesa;
    private int contadorMesa = 0;
    private const double propina = 0.15;
    private double ConsumoMesa;
    private double propinaPorMesa;
    List<Comensal> ComensalesEnMesa = new List<Comensal>();

    public void AgregarComensal(Comensal Objcomensal)
    {
        ComensalesEnMesa.Add(Objcomensal);
    }

    public void ConsumoTotalMesa()
    {
        ConsumoMesa = ComensalesEnMesa.Sum(cliente => cliente.MostrarConsumo());
    }

    public void CalcularPropinaMesa()
    {
        ConsumoTotalMesa();
        propinaPorMesa = ConsumoMesa * propina;
    }

    public void PropinaPorCliente()
    {
        CalcularPropinaMesa();
        foreach (Comensal comensal in ComensalesEnMesa)
        {
            comensal.SetPropinaCliente((comensal.MostrarConsumo() / ConsumoMesa) * propinaPorMesa);
        }
    }

    public void MostrarResumen()
    {
        PropinaPorCliente();
        ConsumoTotalMesa();

        Console.WriteLine("---------------");
        Console.WriteLine("RESUMEN DE MESA");
        Console.WriteLine("---------------");
        Console.WriteLine($"Numero de mesa: {IdMesa}\n");

        foreach (Comensal comensal in ComensalesEnMesa)
        {
            Console.WriteLine($"{comensal.GetNombre()}");
            Console.WriteLine($"Consumo: {comensal.MostrarConsumo()}");
            Console.WriteLine($"Propina: {comensal.GetPropinaConsumo()}");
            Console.WriteLine($"Total: {comensal.GetTotalPropinaConsumo()}\n");
        }

        Console.WriteLine("");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Consumo Total: {ConsumoMesa}");
        Console.WriteLine($"Propina Total: {propinaPorMesa}");
        Console.WriteLine($"Total a Pagar: {ConsumoMesa + propinaPorMesa}");
        Console.WriteLine($"-------------------");
    }
}