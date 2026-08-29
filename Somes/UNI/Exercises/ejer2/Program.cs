public class Program
{
    static void Main(string[] args)
    {
        string nombre = "";

        Console.WriteLine("Bienvenido al Sistema de Facturacion !!!");
        do
        {
            Console.Write("\nIngrese su nombre para comenzar: ");
            nombre = Console.ReadLine()!;

            if (!nombre.All(c => char.IsLetter(c) || c == ' '))
            {
                Console.Write("\nEl nombre solo puede contener letras.\n");
            }

        } while (!nombre.All(c => char.IsLetter(c) || c == ' '));

        Factura FacturaCliente = new Factura(nombre);
        int cantidad = 0;

        while (true)
        {
            try
            {
                Console.Write("\nIngrese la cantidad de productos que desea facturar: ");
                cantidad = int.Parse(Console.ReadLine()!);
                if (cantidad <= 0)
                {
                    Console.WriteLine("No se puede facturar menos de 1 producto !!!");
                }
                else
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("No se permiten letras, intentalo otra vez !!!");
            }
        }

        for (int i = 0; i < cantidad; i++)
        {
            string nombreProducto;
            while (true)
            {
                Console.WriteLine("\nIngrese los siguientes datos: \n");
                Console.Write("Nombre del Producto: ");
                nombreProducto = Console.ReadLine()!;

                if (nombreProducto == "")
                {
                    Console.Write("\nEl campo no puede estar vacio !!!\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("");

            int cantidadProducto;
            while (true)
            {
                try
                {
                    Console.Write("Cantidad de Unidades: ");
                    cantidadProducto = int.Parse(Console.ReadLine()!);
                    if (cantidadProducto <= 0)
                    {
                        Console.Write("\nNo se puede Facturar menos de 1 Producto !!!\n");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNo se permiten Letras en este campo !!!\n");
                }
            }

            Console.WriteLine("");

            double precioProducto;
            while (true)
            {
                try
                {
                    Console.Write("Precio del Producto: ");
                    precioProducto = int.Parse(Console.ReadLine()!);
                    if (precioProducto <= 0)
                    {
                        Console.Write("\nEl valor no puede ser menor que 0 !!!\n");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNo se permiten Letras en este campo !!!\n");
                }
            }

            Producto NuevoProducto = new Producto(nombreProducto, cantidadProducto, precioProducto);
            FacturaCliente.AgregarProducto(NuevoProducto);

        }// Fin for

        bool flag = true;
        int num = 0;

        do
        {
            try
            {
                bool attempt = true;
                while (attempt)
                {
                    Console.WriteLine("\nIngrese segun la opcion: ");
                    Console.WriteLine("1. Agregar un nuevo Producto");
                    Console.WriteLine("2. Eliminar un producto");
                    Console.WriteLine("3. Mostrar Factura Final y Salir");
                    num = int.Parse(Console.ReadLine()!);
                    attempt = false;
                }
            }
            catch (FormatException)
            {
                Console.Write("\nNo se permiten letras en este campo !!!\n");
            }

            switch (num)
            {
                case 1:
                    // Agregar Productos...
                    string nombreProducto;
                    Console.WriteLine("Ingrese los siguientes datos: \n");
                    while (true)
                    {
                        Console.Write("Nombre del Producto: ");
                        nombreProducto = Console.ReadLine()!;

                        if (nombreProducto == "")
                        {
                            Console.Write("\nEl campo no puede estar vacio !!!\n");
                        }
                        else
                        {
                            break;
                        }
                    }

                    Console.WriteLine("");

                    int cantidadProducto;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Cantidad de Unidades: ");
                            cantidadProducto = int.Parse(Console.ReadLine()!);

                            if (cantidadProducto <= 0)
                            {
                                Console.Write("\nNo se puede Facturar menos de 1 Producto !!! \n");
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nNo se permiten Letras en este campo !!!\n");
                        }
                    }

                    Console.WriteLine("");

                    double precioProducto;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Precio del Producto: ");
                            precioProducto = int.Parse(Console.ReadLine()!);

                            if (precioProducto <= 0)
                            {
                                Console.Write("\nEl valor no puede ser menor que 0 !!!\n");
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nNo se permiten Letras en este campo !!!\n");
                        }
                    }

                    Producto NuevoProducto = new Producto(nombreProducto, cantidadProducto, precioProducto);
                    FacturaCliente.AgregarProducto(NuevoProducto);
                    break;

                case 2:
                    // eliminar productos...
                    FacturaCliente.MostrarProductosIngresados();
                    Console.WriteLine("\nCual de los Productos desea eliminar ?.");
                    Console.Write("Ingrese el identificador del producto: ");
                    string id = Console.ReadLine()!;
                    FacturaCliente.EliminarProducto(id);
                    break;

                case 3:
                    // Mostrar Factura Final Y salir ...
                    FacturaCliente.MostrarFactura();
                    flag = false; // <-- Finaliza el programa ...
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (flag);
    }
}