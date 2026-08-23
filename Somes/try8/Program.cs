//--------------1,  2,  3,  4,  5,  6,  7,  8,  9--------
int[] array = { 10, 11, 12, 13, 15, 22, 39, 35, 55 };
//--------------0,  1,  2,  3,  4,  5,  6,  7,  8--------

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"El elemento actual es: [{array[i]}], y su posicion actual es la: [{i}]");
}

/*
i ++, sumar 1 al valor.
 - Es i menor o igual que la cantidad total de elementos? (array.Length) -> 9;
i = 0 ; 9, pass.
i = 1 ; 9, pass.
i = 2 ; 9, pass.
i = 3 ; 9, pass.
i = 4 ; 9, pass.
i = 5 ; 9, pass.
i = 6 ; 9, pass.
i = 7 ; 9, pass.
i = 8 ; 9, pass; ----> Hasta aqui se cumple la condicion.
i = 9 ; 9, Not Pass; -----> Desbordamiento del array, [Se intenta acceder a posicion inexistente].
*/