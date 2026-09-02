public class Program
{
    static void Main(string[] args)
    {
        Mesa mesa = new Mesa();
        Console.WriteLine("Bienvenido al Restaurante !!!");
        Console.Write("Ingrese la cantida de comensales que nos visitan hoy: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine()!;
            Console.Write("Ingrese su consumo: ");
            double consumo = int.Parse(Console.ReadLine()!);

            Comensal Cliente = new Comensal(nombre, consumo);
            mesa.AgregarComensal(Cliente);

            bool flag = true;
            do
            {
                Console.WriteLine("\nDesea agregar otro consumo ?");
                Console.WriteLine("Ingrese Y para agregar otro consumo.");
                Console.WriteLine("Ingrese N para continuar");
                string opcion = Console.ReadLine()!.ToLower();

                switch (opcion)
                {
                    case "y":
                        Console.Write("\nIngrese el valor del consumo a agregar: ");
                        int valor = int.Parse(Console.ReadLine()!);
                        Cliente.AgregarConsumo(valor);
                        flag = false;
                        break;
                    case "n":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("valor no valido !!!");
                        break;

                }
            } while (flag);
        }

        mesa.MostrarResumen();
    }
}