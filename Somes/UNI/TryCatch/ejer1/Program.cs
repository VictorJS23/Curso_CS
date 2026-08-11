/*
Ejercicio 1: Declara un string para guardar un nombre, pero asígnale el valor null
intencionadamente. Dentro de un bloque try, intenta acceder a una propiedad de ese 
string, como su longitud (nombre.Length) o convertirlo a mayúsculas 
(nombre.ToUpper()). En el bloque catch, captura la NullReferenceException y muestra el 
mensaje: "Error: Se intentó usar una variable de texto que no tiene valor (es nula)".
*/

string name = null;

try
{
    Console.WriteLine($"La longitud de la cadena es de {name.Length}");
}
catch (NullReferenceException e)
{
    Console.WriteLine("Esto no se puede hacer porque: " + e.Message);
}