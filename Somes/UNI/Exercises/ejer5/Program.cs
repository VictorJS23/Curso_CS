using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario();

        bool flag = true;
        int opcion = 0;

        do
        {
            try
            {
                bool intento = true;

                while (intento)
                {
                    Console.WriteLine("Bienvenido al Sistema de Inventario\n");
                    Console.WriteLine("Ingrese segun la opcion.");
                    Console.WriteLine("1. Agregar Producto al Inventario.");
                    Console.WriteLine("2. Eliminar Producto del Inventario.");
                    Console.WriteLine("3. Mostrar Inventario.");
                    Console.WriteLine("4. Mostrar Productos con menor Stock.");
                    Console.WriteLine("5. Vender Productos");
                    Console.WriteLine("6. Reponer Productos");
                    Console.WriteLine("7. Mostrar Valor total del inventario.");
                    Console.WriteLine("8. Salir.");

                    opcion = int.Parse(Console.ReadLine()!);
                    intento = false;
                }
            }
            catch (FormatException)
            {
                Console.Write("\nNo se permiten letras en este campo !!!\n");
                Console.WriteLine("");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    // Agregar Producto...
                    string codigoBarra;

                    Console.WriteLine("Ingrese los siguientes datos: \n");

                    while (true)
                    {
                        Console.Write("Ingrese el codigo de barras del Producto: ");
                        codigoBarra = Console.ReadLine()!;

                        if (codigoBarra == "")
                        {
                            Console.Write("\nEl campo no puede estar vacio !!!\n");
                            continue;
                        }

                        bool existe = inventario.BuscarProducto(codigoBarra) != -1;

                        if (existe)
                        {
                            Console.Write("El producto ya existe, ingresa otro codigo!!!\n");
                            continue;
                        }

                        if (inventario.ValidarCodigo(codigoBarra))
                        {
                            Console.Write("Ingrese el nombre de la Categoria del producto a ingresar: ");
                            string nombreCat = Console.ReadLine()!;

                            Console.Write("Ingrese una breve descripcion para la categoria ingresada: ");
                            string descrip = Console.ReadLine()!;

                            Categoria categoria = new Categoria(nombreCat, descrip);

                            Console.Write("Ingrese el Nombre de el Producto: ");
                            string nombre = Console.ReadLine()!;

                            decimal precio;

                            while (true)
                            {
                                try
                                {
                                    Console.Write("Ingrese el precio del producto: ");
                                    precio = decimal.Parse(Console.ReadLine()!);

                                    if (precio <= 0)
                                    {
                                        Console.WriteLine("El precio no puede ser menor que 1.");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("No se permiten letras en este campo !!!");
                                }
                            }

                            int stock;

                            while (true)
                            {
                                try
                                {
                                    Console.Write("Ingrese el Stock del Producto: ");
                                    stock = int.Parse(Console.ReadLine()!);

                                    if (stock > 0)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Tienes que agregar minimo 1 de stock !!!");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("No se permiten letras en este campo !!!");
                                }
                            }

                            Producto producto = new Producto(
                                codigoBarra,
                                nombre,
                                precio,
                                stock,
                                categoria
                            );

                            inventario.AgregarProducto(producto);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Codigo de barra Invalido, Intente nuevamente !!!");
                        }
                    }
                    break;

                case 2:
                    // Eliminar Producto...
                    while (true)
                    {
                        Console.Write("Ingrese el codigo del producto que desea eliminar: ");
                        string codigo = Console.ReadLine()!;

                        string clave = inventario.EliminarProducto(codigo);
                        if (clave == "S" && codigo.All(char.IsDigit))
                        {
                            break;
                        }
                    }
                    break;

                case 3:
                    // Mostrar Inventario...
                    bool acceso = inventario.InventarioVacio();

                    if (!acceso)
                    {
                        inventario.MostrarInventario();
                    }
                    else
                    {
                        Console.WriteLine("El inventario esta vacio !!!");
                    }
                    break;

                case 4:
                    // Mostrar Productos con menor stock...
                    bool acceso2 = inventario.InventarioVacio();

                    if (!acceso2)
                    {
                        inventario.MostrarProductosBajoStock();
                    }
                    else
                    {
                        Console.WriteLine("El inventario esta vacio !!!");
                    }
                    break;

                case 5:
                    // Vender Productos
                    while (true)
                    {
                        Console.Write("Ingrese el codigo de barras del Producto que desea Vender: ");
                        string codigo = Console.ReadLine()!;

                        if (codigo == "")
                        {
                            Console.Write("\nEl campo no puede estar vacio !!!\n");
                            continue;
                        }

                        bool existe2 = inventario.BuscarProducto(codigo) != -1;

                        if (!existe2)
                        {
                            Console.Write("El producto no existe, ingresa otro codigo!!!\n");
                            continue;
                        }

                        int cantidad;

                        while (true)
                        {
                            try
                            {
                                Console.Write("Ingrese la cantidad a vender: ");
                                cantidad = int.Parse(Console.ReadLine()!);

                                if (cantidad <= 0)
                                {
                                    Console.WriteLine("No se puede vender menos que 1 unidad.");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("No se permiten letras en este campo !!!");
                            }
                        }

                        string resultado = inventario.VenderProducto(codigo, cantidad);

                        if (resultado == "S")
                        {
                            break;
                        }
                    }

                    break;

                case 6:
                    // Reponer Productos...
                    while (true)
                    {
                        Console.Write("Ingrese el codigo de barras del Producto que desea Reponer: ");
                        string codigo2 = Console.ReadLine()!;

                        if (codigo2 == "")
                        {
                            Console.Write("\nEl campo no puede estar vacio !!!\n");
                            continue;
                        }

                        bool existe3 = inventario.BuscarProducto(codigo2) != -1;

                        if (!existe3)
                        {
                            Console.Write("El producto no existe, ingresa otro codigo!!!\n");
                            continue;
                        }

                        int cantidad;

                        while (true)
                        {
                            try
                            {
                                Console.Write("Ingrese la cantidad a Reponer: ");
                                cantidad = int.Parse(Console.ReadLine()!);

                                if (cantidad <= 0)
                                {
                                    Console.WriteLine("No se puede Reponer menos que 1 unidad.");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("No se permiten letras en este campo !!!");
                            }
                        }

                        inventario.ReponerProducto(codigo2, cantidad);
                        break;

                    }

                    break;

                case 7:
                    inventario.ValorTotalInventario();
                    break;

                case 8:
                    Console.WriteLine("Gracias por usar nuestro Sistema de inventario !!!");
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Opcion Invalida...");
                    break;
            }

        } while (flag);
    }
}

/*
Codigos verificados para testear:

7501234567893
4006381333931
5901234123457
4003994155486
9780306406157
9780143127741
*/