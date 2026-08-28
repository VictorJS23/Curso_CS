public class EvaluacionIMC
{
    private string nombre;
    private int edad;
    private double altura;
    private double peso;
    private double IMC;
    private string categoria;
    private string recomendacion;

    public EvaluacionIMC()
    {
        nombre = "Si ves este mensaje, el dato no fue proporcionado.";
        edad = 0;
        altura = 0;
        peso = 0;
        IMC = 0;
        categoria = "Si ves este mensaje, el dato no fue proporcionado.";
        recomendacion = "Si ves este mensaje, el dato no fue proporcionado.";

    }

    public void GetDatos(string nombre, int edad, double altura, double peso)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.altura = altura;
        this.peso = peso;
    }


    void CalcularIMC()
    {
        IMC = peso / Math.Pow(altura, 2);
    }

    void getCategoria()
    {
        if (IMC >= 30)
            categoria = "Obesidad";
        else if (IMC >= 25)
            categoria = "Sobrepeso";
        else if (IMC >= 18.5)
            categoria = "Peso Normal";
        else
            categoria = "Bajo Peso";
    }

    void getRecomendacion()
    {
        switch (categoria)
        {
            case "Obesidad":
                recomendacion = "El estado de Obesidad no es saludable.";
                break;
            case "Sobrepeso":
                recomendacion = "Debe mejorar, el Sobrepeso no es saludable";
                break;
            case "Peso Normal":
                recomendacion = "Perfecto, tienes un Peso Normal";
                break;
            case "Bajo Peso":
                recomendacion = "Debes subir de peso, no es saludable";
                break;
        }
    }

    public void MostrarReporte(EvaluacionIMC Persona)
    {
        CalcularIMC();
        getCategoria();
        getRecomendacion();

        int anchoEtiqueta = 15;
        int anchoValor = 30;
        int anchoTotal = anchoEtiqueta + anchoValor + 3; // 3 = bordes y separador

        string linea = "+" + new string('-', anchoTotal - 2) + "+";
        string separador = "+" + new string('-', anchoEtiqueta) + "+" + new string('-', anchoValor - 1) + "+";

        Console.WriteLine(linea);
        Console.WriteLine($"|{CentrarTexto("REPORTE IMC", anchoTotal - 2)}|");
        Console.WriteLine(separador);

        ImprimirFila("Nombre", Persona.nombre, anchoEtiqueta, anchoValor);
        ImprimirFila("Edad", Persona.edad.ToString(), anchoEtiqueta, anchoValor);
        ImprimirFila("Peso", $"{Persona.peso} kg", anchoEtiqueta, anchoValor);
        ImprimirFila("Estatura", $"{Persona.altura} m", anchoEtiqueta, anchoValor);
        ImprimirFila("IMC", Persona.IMC.ToString("F2"), anchoEtiqueta, anchoValor);
        ImprimirFila("Categoria", Persona.categoria, anchoEtiqueta, anchoValor);
        ImprimirFila("Recomendacion", Persona.recomendacion, anchoEtiqueta, anchoValor);

        Console.WriteLine(separador);
    }

    private void ImprimirFila(string etiqueta, string valor, int anchoEtiqueta, int anchoValor)
    {
        // Si el valor es muy largo, lo dividimos en varias líneas
        var lineasValor = DividirTexto(valor, anchoValor - 2);

        for (int i = 0; i < lineasValor.Count; i++)
        {
            string col1 = i == 0 ? etiqueta.PadRight(anchoEtiqueta) : new string(' ', anchoEtiqueta);
            Console.WriteLine($"|{col1}| {lineasValor[i].PadRight(anchoValor - 2)}|");
        }
    }

    private List<string> DividirTexto(string texto, int anchoMax)
    {
        var resultado = new List<string>();
        while (texto.Length > anchoMax)
        {
            int corte = texto.LastIndexOf(' ', anchoMax);
            if (corte <= 0) corte = anchoMax;
            resultado.Add(texto.Substring(0, corte));
            texto = texto.Substring(corte).TrimStart();
        }
        resultado.Add(texto);
        return resultado;
    }

    private string CentrarTexto(string texto, int ancho)
    {
        int espacios = ancho - texto.Length;
        int izquierda = espacios / 2;
        int derecha = espacios - izquierda;
        return new string(' ', izquierda) + texto + new string(' ', derecha);
    }
}
