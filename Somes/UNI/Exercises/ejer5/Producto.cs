using System.Data;

public class Producto
{
    private string codigo;
    private string nombre;
    private decimal precio;
    private int stock;
    public Categoria Categoria { get; set; }
    public string Codigo { get => codigo; }
    public string Nombre { get => nombre; }
    public decimal Precio { get => precio; }
    public int Stock { get => stock; set => stock = value; }

    public Producto(string codigo, string nombre, decimal precio, int stock, Categoria categoria)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
        this.Categoria = categoria;
    }

    public void AumentarStock(int cantidad)
    {
        stock += cantidad;
    }

    public void DisminuirStock(int cantidad)
    {
        if (cantidad <= stock)
        {
            stock -= cantidad;
        }
    }

    public bool HayStock(int cantidad)
    {
        return stock >= cantidad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Codigo: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Precio: {precio}");
        Console.WriteLine($"Stock: {stock}");
        Console.WriteLine($"Categoria{Categoria.NombreCategoria}");
    }
}