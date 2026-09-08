using System.Runtime.InteropServices;

public class Inventario
{
    List<Producto> productos = new List<Producto>();

    public void OrdenarLista()
    {
        productos.Sort((producto1, producto2) => producto1.Codigo.CompareTo(producto2.Codigo));
    }

    public bool ValidarCodigo(string codigo)
    {
        if (codigo.Length != 13)
            return false;

        if (!codigo.All(char.IsDigit))
            return false;

        int suma = 0;

        for (int i = 0; i < 12; i++)
        {
            int digito = int.Parse(codigo[i].ToString());

            if (i % 2 == 0)
                suma += digito;
            else
                suma += digito * 3;
        }

        int digitoControl = (10 - (suma % 10)) % 10;

        return digitoControl == int.Parse(codigo[12].ToString());
    }

    public int BuscarProducto(string codigo)
    {
        int izquierda = 0;
        int derecha = productos.Count - 1;

        while (izquierda <= derecha)
        {
            int pivot = (izquierda + derecha) / 2;

            if (productos[pivot].Codigo == codigo)
            {
                return pivot;
            }
            else if (productos[pivot].Codigo.CompareTo(codigo) < 0)
            {
                izquierda = pivot + 1;
            }
            else
            {
                derecha = pivot - 1;
            }
        }

        return -1;
    }

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
        OrdenarLista();
    }

    public string EliminarProducto(string codigo)
    {
        int posicion = BuscarProducto(codigo);

        if (posicion != -1)
        {
            productos.RemoveAt(posicion);
            Console.WriteLine("\nProducto eliminado con exito !!!\n");
            return "S";
        }
        else
        {
            Console.WriteLine("\nProducto no encontrado !!!\n");
            return "N";
        }
    }

    public string VenderProducto(string codigo, int cantidad)
    {
        int posicion = BuscarProducto(codigo);

        Producto producto1 = productos[posicion];

        if (!producto1.HayStock(cantidad))
        {
            Console.WriteLine("No hay suficiente stock para realizar la venta !!!");
            return "N";
        }

        producto1.DisminuirStock(cantidad);

        Console.WriteLine("Producto vendido correctamente !!!");
        return "S";
    }

    public void ReponerProducto(string codigo, int cantidad)
    {
        int posicion = BuscarProducto(codigo);

        Producto producto = productos[posicion];

        producto.AumentarStock(cantidad);

        Console.WriteLine("Producto repuesto correctamente !!!");
    }

    public bool InventarioVacio()
    {
        return productos.Count == 0;
    }

    public void MostrarProductosBajoStock()
    {
        Console.WriteLine("=============================================");
        Console.WriteLine("             PRODUCTOS CON BAJO STOCK");
        Console.WriteLine("=============================================");

        foreach (Producto producto in productos)
        {
            if (producto.Stock <= 5)
            {
                Console.WriteLine(producto.MostrarInformacion());
                Console.WriteLine("---------------------------------------------");
            }
        }

        Console.WriteLine("=============================================");
    }

    public void MostrarInventario()
    {
        Console.WriteLine("=============================================");
        Console.WriteLine("              INVENTARIO");
        Console.WriteLine("=============================================");

        Console.WriteLine("{0,-10} {1,-15} {2,-10} {3,-5}",
            "Código", "Producto", "Precio", "Stock");

        Console.WriteLine("---------------------------------------------");

        foreach (Producto producto in productos)
        {
            Console.WriteLine(producto.MostrarInformacion());
        }
        Console.WriteLine("=============================================");
    }

    public decimal ValorTotalInventario()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("El inventario está vacío.");
            return 0;
        }

        decimal total = 0;

        foreach (Producto producto in productos)
        {
            total += producto.Precio * producto.Stock;
        }

        Console.WriteLine($"El valor total del inventario es: C${total}");

        return total;
    }
}