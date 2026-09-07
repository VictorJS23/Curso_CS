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

    public string AgregarProducto(Producto producto)
    {
        bool existe = BuscarProducto(producto.Codigo) != -1;

        if (!existe)
        {
            productos.Add(producto);
            OrdenarLista();
            return "Hecho";
        }
        else
        {
            Console.WriteLine("El producto ya existe !!!");
            return "Fallo";
        }
    }

    public string EliminarProducto(string codigo)
    {
        int posicion = BuscarProducto(codigo);

        if (posicion != -1)
        {
            productos.RemoveAt(posicion);
            return "Hecho";
        }
        else
        {
            Console.WriteLine("No se puede eliminar un producto no existente");
            return "Fallo";
        }
    }

    public string VenderProducto(Producto producto, int cantidad)
    {
        bool existe = BuscarProducto(producto.Codigo) != -1;

        if (existe)
        {
            if (cantidad > 0 && cantidad <= producto.Stock)
            {
                producto.Stock -= cantidad;
                return "Hecho";
            }

            Console.WriteLine("No hay suficiente stock o la cantidad no es válida");
            return "Casi";
        }
        else
        {
            Console.WriteLine("El producto no se puede vender, no existe !!!");
            return "Fallo";
        }
    }

    public string ReponerProducto(Producto producto, int cantidad)
    {
        bool existe = BuscarProducto(producto.Codigo) != -1;

        if (existe && cantidad > 0)
        {
            producto.Stock += cantidad;
            return "Hecho";
        }
        else
        {
            Console.WriteLine("El producto no puede reponer stock, no existe o la cantidad no es válida.");
            return "Fallo";
        }
    }

    public void MostrarInventario()
    {
        Console.WriteLine("=============================================");
        Console.WriteLine("                INVENTARIO");
        Console.WriteLine("=============================================");

        Console.WriteLine("{0,-10} {1,-15} {2,-10} {3,-5}",
            "Código", "Producto", "Precio", "Stock");

        Console.WriteLine("---------------------------------------------");

        foreach (Producto producto in productos)
        {
            Console.WriteLine("{0,-10} {1,-15} C${2,-8} {3,-5}",
                producto.Codigo,
                producto.Nombre,
                producto.Precio,
                producto.Stock);
        }
        Console.WriteLine("=============================================");
    }
}