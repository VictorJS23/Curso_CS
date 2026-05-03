/*
programa en C# solicita el sexo (chico o chica) y la edad de una persona para determinar si
puede entrar a una discoteca: si es menor de 18, no puede entrar; si es mayor de edad, las
chicas entran gratis y los chicos pagan.
*/

Console.Write("Ingrese su sexo: ");
string sexo = Console.ReadLine();
Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    if (sexo == "mujer")
    {
        Console.WriteLine("Puedes pasar, tenes buen papoi");
    }
    else
    {
        Console.WriteLine("Andate a la pija machista");
    }
}
else
{
    Console.WriteLine("Eres menor de edad, no puedes pasar !!!");
}
