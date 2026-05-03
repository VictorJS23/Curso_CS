/*
Programa en C# calcula el promedio de cuatro notas y clasifica el rendimiento del
estudiante como Excelente (promedio >= 90 && promedio <= 100), Muy Bueno (promedio
>= 80 && promedio < 90), Bueno (promedio >= 75 && promedio < 80), Regular o eficiente
(promedio >= 70 && promedio < 75) según el promedio obtenido.
*/

class Estudiante
{
    public string nombre;
    public double[] notas = new double[4];
}

class Program
{
    static void Main()
    {
        Estudiante[] alumnos = new Estudiante[4];

        for (int i = 0; i < alumnos.Length; i++)
        {
            alumnos[i] = new Estudiante();
        }

        LeerDatos(alumnos);
    }

    public static void LeerDatos(Estudiante[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Ingrese el nombre del estudiante [{i + 1}]: ");
            array[i].nombre = Console.ReadLine();

            for (int j = 0; j < array[i].notas.Length; j++)
            {
                Console.Write($"Ingrese la nota {j + 1} de {array[i].nombre}: ");
                array[i].notas[j] = double.Parse(Console.ReadLine());
            }
        }
    }
}