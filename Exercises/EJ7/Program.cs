/*
Encontrar la secuencia creciente ininterrumpida más larga.
Implementa un método que encuentre la secuencia creciente más larga en un arreglo de números enteros. La secuencia creciente es una secuencia de números en la que cada número es mayor que el anterior.
Ejemplo:
Arreglo:
[1, 3, 2, 4, 8, 7, 9]
La secuencia creciente más larga sería:
2, 4, 8
Otro ejemplo:
[1, 3, 2, 4, 8, 7, 9, 11, 25, 200]
La secuencia más larga sería:
7, 9, 11, 25, 200
*/

int[] array = { 1, 3, 2, 4, 8, 7, 9, 11, 25, 200 };

// Inicio de la secuencia actual
int inicioActual = 0;

// Longitud de la secuencia actual
int longitudActual = 1;

// Mejor secuencia encontrada
int mejorInicio = 0;
int mejorLongitud = 1;

for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] < array[i + 1])
    {
        // Sigue creciendo
        longitudActual++;
    }
    else
    {
        // Se rompió la secuencia

        if (longitudActual > mejorLongitud)
        {
            mejorLongitud = longitudActual;
            mejorInicio = inicioActual;
        }

        // Reiniciar secuencia
        inicioActual = i + 1;
        longitudActual = 1;
    }
}

// ⚠️ Verificar la última secuencia
if (longitudActual > mejorLongitud)
{
    mejorLongitud = longitudActual;
    mejorInicio = inicioActual;
}

// Mostrar resultado
Console.WriteLine("Secuencia creciente más larga:");

for (int i = mejorInicio; i < mejorInicio + mejorLongitud; i++)
{
    Console.Write(array[i] + " ");
}

/*
EXPLICACIÓN DEL ALGORITMO:

El objetivo es encontrar la secuencia creciente consecutiva más larga dentro de un arreglo.
Una secuencia creciente significa que cada número es mayor que el anterior.

IDEA PRINCIPAL:
No es necesario guardar todos los números mientras recorremos el arreglo.
En su lugar, trabajamos con posiciones (índices) y longitudes.

VARIABLES USADAS:
- inicioActual: indica dónde empieza la secuencia actual
- longitudActual: indica cuántos elementos tiene la secuencia actual
- mejorInicio: indica dónde empieza la mejor secuencia encontrada
- mejorLongitud: indica la longitud de la mejor secuencia

RECORRIDO DEL ARREGLO:
Se recorre el arreglo comparando cada elemento con el siguiente (array[i] con array[i + 1]).

CASOS:

1. Si el siguiente número es mayor (array[i] < array[i + 1]):
   - La secuencia sigue creciendo
   - Se incrementa longitudActual

2. Si el siguiente número NO es mayor:
   - La secuencia se rompe
   - Se compara la secuencia actual con la mejor encontrada:
       Si longitudActual > mejorLongitud:
           Se actualizan mejorLongitud y mejorInicio
   - Se reinicia la secuencia:
       inicioActual = i + 1
       longitudActual = 1

IMPORTANTE:
Al terminar el ciclo, se debe hacer una última comparación,
porque la secuencia más larga podría estar al final del arreglo.

IMPRESIÓN DEL RESULTADO:
Se usa mejorInicio y mejorLongitud para recorrer e imprimir la secuencia más larga.

RESUMEN:
- Mientras los números aumenten → la secuencia continúa
- Si disminuyen → se guarda la mejor y se reinicia
- Al final → se vuelve a comparar por seguridad

Este enfoque es eficiente porque solo recorre el arreglo una vez (O(n))
y no utiliza estructuras adicionales como listas.
*/