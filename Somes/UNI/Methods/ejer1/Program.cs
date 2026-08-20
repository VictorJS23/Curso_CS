class Program
{
    static void Main(string[] args)
    {
        double precio;
        int cantidad;

        PedirDatos(out precio, out cantidad);
        double total = CalcularResultado(precio, cantidad);
        MostrarResultado(precio, cantidad, total);
    }

    static void PedirDatos(out double precio, out int cantidad)
    {
        Console.WriteLine("Ingrese el precio del producto: ");
        precio = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad = int.Parse(Console.ReadLine());
    }

    static double CalcularResultado(double precio, int cantidad)
    {
        return precio * cantidad;
    }

    static void MostrarResultado(double precio, int cantidad, double total)
    {
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Precio: " + precio);
        Console.WriteLine("Total: " + total);
    }
}