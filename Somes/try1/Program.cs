/*
programa en C# solicita el sexo (chico o chica) y la edad de una persona para determinar si
puede entrar a una discoteca: si es menor de 18, no puede entrar; si es mayor de edad, las
chicas entran gratis y los chicos pagan.
*/

class Persona // Clase Unica
{
    public string sexo; // Atributos
    public int edad; // Atributos
    public string name; // Atributos

    public void Saludar() // Metodo Propio de la clase
    {
        Console.WriteLine($"Hola mi nombre es {name}, tengo {edad} anios, y soy {sexo}");
    }

}
class Persona2 // Clase Unica
{
    public void papoi() // Metodo exlusivo de esta clase
    {
        Console.WriteLine($"YO GRITO PAPOI");
    }

}

class Program
{
    static void Main()
    {
        Persona person1 = new Persona(); //Creacion del objeto, con los Atributos de la clase Persona

        Console.WriteLine("Ingrese su Nombre: ");
        person1.name = Console.ReadLine();
        Console.WriteLine("Ingrese su sexo: ");
        person1.sexo = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        person1.edad = int.Parse(Console.ReadLine());
        Console.WriteLine(ImprimirResultado(person1));
        person1.Saludar();

        //--------------------------------------

        Persona2 person2 = new Persona2(); //Creacion del objeto, con los Atributos de la clase Persona2
        person2.papoi();
    }

    public static string ImprimirResultado(Persona person)
    {
        string sexo = person.sexo.ToLower();

        if (person.edad >= 18)
        {
            if (sexo == "mujer")
            {
                return "Puedes pasar gratis mujer";
            }
            else if (sexo == "hombre")
            {
                return "Paga";
            }
            else
            {
                return "Sexo no válido";
            }
        }
        else
        {
            return "No puedes entrar";
        }
    }
}