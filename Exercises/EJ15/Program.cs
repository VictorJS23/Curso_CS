// Imprime hasta n la sucesion de Fibonacci

int first = 0;
int second = 1;
int result = 0;

for (int i = 0; i <= 10; i++)
{
    if (i == 0)
    {
        Console.WriteLine(first);
        continue;
    }
    if (i == 1)
    {
        Console.WriteLine(second);
        continue;
    }

    result = first + second;
    Console.WriteLine(result);

    first = second;
    second = result;
}