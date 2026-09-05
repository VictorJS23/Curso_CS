class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Disnorte");

        Console.Write("Ingrese su Nombre: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Ingrese su direccion: ");
        string direccion = Console.ReadLine()!;

        Cliente cliente = new Cliente(nombre, direccion);

        Console.WriteLine("");

        Console.Write("Ingrese la Lectura Anterior del medidor: ");
        double anterior = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la Lectura Actual del medidor: ");
        double actual = double.Parse(Console.ReadLine()!);

        Medidor medidor = new Medidor(actual, anterior);

        medidor.CalcularConsumo();

        Factura factura = new Factura(medidor);

        factura.MostrarFactura(cliente);
    }
}