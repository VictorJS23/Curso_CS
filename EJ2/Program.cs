/*
2.
Hacer un programa que calcule e imprima el salario semanal de un empleado a partir de sus horas semanales trabajadas y de su salario por hora. Se asume que trabaja 7 dias.
*/

// asumimos que el pago por hora es de 15$, y trabaja 8 hrs al dia

Console.WriteLine("Digite las horas trabajadas en la semana");
int horas = int.Parse(Console.ReadLine());

Console.WriteLine($"El salario resultante por las {horas}, trabajadas es de: {(15 * 8) * horas}");