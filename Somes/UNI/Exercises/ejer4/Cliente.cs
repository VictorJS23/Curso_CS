public class Cliente
{
    private static int contadorId = 0;
    private string IdCliente;
    private string nombreCliente = "0";
    private string direccionCliente = "0";

    public Cliente(string nombreCliente, string direccionCliente)
    {
        this.nombreCliente = nombreCliente;
        this.direccionCliente = direccionCliente;

        contadorId++;
        IdCliente = contadorId.ToString("D4");
    }

    public string GetNombre()
    {
        return nombreCliente;
    }

    public string GetDireccion()
    {
        return direccionCliente;
    }
}