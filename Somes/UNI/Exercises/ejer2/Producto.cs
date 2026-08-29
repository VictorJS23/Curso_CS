public class Producto
{
    public Producto(string NombreItem, int CantidadItem, double PrecioItem)
    {
        ContadorItem++;
        IdItem = ContadorItem.ToString("D4");
        this.NombreItem = NombreItem;
        this.CantidadItem = CantidadItem;
        this.PrecioItem = PrecioItem;
    }

    private static int ContadorItem = 0;
    private string NombreItem = "";
    private double PrecioItem;
    private int CantidadItem;
    private string IdItem;
    private double SubTotal;

    public void CalcularSubtotal()
    {
        SubTotal = PrecioItem * CantidadItem;
    }

    public string GetIdItem()
    {
        return IdItem;
    }

    public string GetNombreItem()
    {
        return NombreItem;
    }

    public double GetPrecioItem()
    {
        return PrecioItem;
    }

    public int GetCantidadItem()
    {
        return CantidadItem;
    }

    public double GetSubTotal()
    {
        CalcularSubtotal();
        return SubTotal;
    }
}