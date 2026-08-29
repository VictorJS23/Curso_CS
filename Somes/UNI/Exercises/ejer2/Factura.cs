using System.Text.RegularExpressions;
public class Factura
{
    public Factura(string NombreCliente)
    {
        ContadorFactura++;
        IdFactura = ContadorFactura.ToString("D4");
        this.NombreCliente = NombreCliente;
    }

    private static int ContadorFactura = 0;
    private string IdFactura;
    private string NombreCliente = "";
    private const double IVA = 0.15;
    private double SubIVA;
    private double SubtotalGeneral;
    private double TotalFinal;
    List<Producto> Productos = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void MostrarProductosIngresados()
    {
        Console.WriteLine("");
        foreach (Producto producto in Productos)
        {
            Console.WriteLine($"{producto.GetIdItem()} - {producto.GetNombreItem()}        {producto.GetCantidadItem()} x {producto.GetPrecioItem()} = C${producto.GetSubTotal()}\n");
        }
    }

    public void EliminarProducto(string id)
    {
        if (!Regex.IsMatch(id, @"^\d{4}$"))
        {
            Console.WriteLine("ID inválido. Debe tener exactamente 4 dígitos numéricos.");
            return;
        }

        int posicion = Productos.FindIndex(p => p.GetIdItem() == id);

        if (posicion != -1)
        {
            Productos.RemoveAt(posicion);
            Console.WriteLine("Producto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró el producto.");
        }
    }

    public void CalcularSubTotal()
    {
        SubtotalGeneral = Productos.Sum(p => p.GetSubTotal());
    }

    public void CalcularTotalConIVA()
    {
        SubIVA = SubtotalGeneral * IVA;
        TotalFinal = SubtotalGeneral + SubIVA;
    }

    public void MostrarFactura()
    {
        CalcularSubTotal();
        CalcularTotalConIVA();

        Console.WriteLine("-------------------------------");
        Console.WriteLine("            FACTURA           ");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"ID. Factura: {IdFactura}");
        Console.WriteLine($"Cliente: {NombreCliente}\n");

        foreach (Producto producto in Productos)
        {
            Console.WriteLine(
                $"{producto.GetIdItem()} - {producto.GetNombreItem()} " +
                $"{producto.GetCantidadItem()} x {producto.GetPrecioItem()} = " +
                $"C${producto.GetSubTotal()}\n"
            );
        }

        Console.WriteLine($"Subtotal: C${SubtotalGeneral}");
        Console.WriteLine($"IVA: C${SubIVA}");
        Console.WriteLine($"Total: C${TotalFinal}");
    }
}