public class Factura
{
    private static int contadorFactura = 0;
    private string IdFactura = "";
    private double precioKwh = 5;
    private double subTotal;
    private double impuesto;
    private double total;
    private Medidor consumo;

    public Factura(Medidor consumo)
    {
        contadorFactura++;
        IdFactura = "F" + contadorFactura.ToString("D4");
        this.consumo = consumo;
    }

    public void CalcularSubtotal()
    {
        double valor = consumo.GetConsumo();
        subTotal = valor * precioKwh;
    }

    public void CalcularImpuesto()
    {
        CalcularSubtotal();
        impuesto = subTotal * 0.15;
    }

    public void CalcularTotal()
    {
        CalcularImpuesto();
        total = subTotal + impuesto;
    }

    public void MostrarFactura(Cliente cliente)
    {
        CalcularTotal();

        Console.WriteLine($"========== FACTURA ==========");
        Console.WriteLine($"Cliente: {cliente.GetNombre()}");
        Console.WriteLine($"Direccion: {cliente.GetDireccion()}");
        Console.WriteLine($"ID Factura: {IdFactura}");
        Console.WriteLine($"Medidor: {consumo.GetIdMedidor()}\n");
        Console.WriteLine($"Lectura Anterior: {consumo.GetAnterior()} kWh");
        Console.WriteLine($"Lectura Actual: {consumo.GetActual()} kWh\n");
        Console.WriteLine($"Consumo: {consumo.GetConsumo()} kWh");
        Console.WriteLine($"Precio/kWh: C${precioKwh}\n");
        Console.WriteLine($"SubTotal: C${subTotal}");
        Console.WriteLine($"Impuesto: C${impuesto}\n");
        Console.WriteLine($"Total: C${total}");
        Console.WriteLine($"=============================");
    }
}