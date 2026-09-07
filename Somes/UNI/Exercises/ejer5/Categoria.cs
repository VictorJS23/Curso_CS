public class Categoria
{
    private static int count = 0;
    private string IdCategoria;
    private string categoria;
    private string descripcion;
    public string NombreCategoria { get => categoria; }
    public string IDCategoria { get => IdCategoria; }
    public string Descripcion { get => descripcion; }

    public Categoria(string categoria, string descripcion)
    {
        count++;
        IdCategoria = count.ToString();
        this.categoria = categoria;
        this.descripcion = descripcion;
    }

    public void MostrarCategoria()
    {
        Console.WriteLine($"Id: {IdCategoria}");
        Console.WriteLine($"Nombre de Categoria: {categoria}");
        Console.WriteLine($"Descripcion: {descripcion}");
    }
}