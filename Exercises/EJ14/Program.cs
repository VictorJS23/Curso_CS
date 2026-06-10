List<int> lista = new List<int> { 1, 2, 3, 1, 6, 3, 2, 3, 2, 2, 2, 2, 1, 0 };

lista.Sort();

List<int> ListaNueva = new List<int>();
List<int> ListaCount = new List<int>();

int count = 1;

for (int i = 0; i < lista.Count - 1; i++)
{
    if (lista[i] == lista[i + 1])
    {
        count++;
    }
    else
    {
        ListaNueva.Add(lista[i]);
        ListaCount.Add(count);
        count = 1;
    }
}

// agregar el último número
ListaNueva.Add(lista[lista.Count - 1]);
ListaCount.Add(count);

for (int i = 0; i < ListaNueva.Count; i++)
{
    Console.WriteLine($"El numero [{ListaNueva[i]}], se repite: [{ListaCount[i]}] veces.");
}