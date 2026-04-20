double[] array = new double[5];
double suma = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Ingrese su calificacion: ");
    double nota = double.Parse(Console.ReadLine());
    suma += nota;
}
double promedio = suma / array.Length;
Console.Write("El promedio de notas es: " + promedio);