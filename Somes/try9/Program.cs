/*
Hacer un programa que ejecute lo siguiente
        *
       ***
      *****
     *******
    *********
*/

int size = 9;
int count = size / 2;
int count2 = 0;

for(int i = 1; i <= size; i+=2)
{
    Console.WriteLine(new string(' ', count) + new string('*', i));
    count--;
}

Console.WriteLine("----------");

for(int i = size; i >= 1; i-=2)
{
    Console.WriteLine(new string(' ', count2) + new string('*', i));
    count2++;
}