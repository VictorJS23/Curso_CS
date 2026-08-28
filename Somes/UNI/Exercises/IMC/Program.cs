class Program
{
    static void Main(string[] args)
    {
        EvaluacionIMC Persona = new EvaluacionIMC();

        bool flag = true;

        while (flag)
        {
            try
            {
                Console.WriteLine("Bienvenido a la Calculadora de IMC !!!\n");
                Console.WriteLine("Ingrese los siguientes datos a continuacion: ");

                string nombre;
                do
                {
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine()!;

                    if (!nombre.All(c => char.IsLetter(c) || c == ' '))
                    {
                        Console.WriteLine("\nEl nombre solo puede contener letras.\n");
                    }

                } while (!nombre.All(c => char.IsLetter(c) || c == ' '));

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine()!);
                Console.Write("Estatura : ");
                double estatura = double.Parse(Console.ReadLine()!);
                Console.Write("Peso: ");
                double peso = double.Parse(Console.ReadLine()!);
                Persona.GetDatos(nombre, edad, estatura, peso);

                flag = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNo se permiten Numeros, Intentalo otra vez !!!\n");
            }
        }

        Persona.MostrarReporte(Persona);
    }
}