using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        int[] array = { 2, 5, 2, 8, 5, 2, 9, 5, 5 };

        List<Numero> Elementos = new List<Numero>();

        for (int i = 0; i < array.Length; i++)
        {
            // Verificamos si este número ya fue procesado
            if (Elementos.Any(n => n.valor == array[i]))
            {
                continue;
            }

            int count = 1;

            // Buscamos las repeticiones que están después
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }

            Elementos.Add(new Numero
            {
                valor = array[i],
                repeticiones = count
            });
        }

        foreach (Numero n in Elementos)
        {
            Console.WriteLine($"{n.valor} --- {n.repeticiones}");
        }
    }

    class Numero
    {
        public int valor;
        public int repeticiones;
    }
}