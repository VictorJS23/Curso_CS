/*
7.
Hacer un programa que dado un numero de horas, devuelva la cantidad de semanas dias y horas equivalentes.
Ejemplo: Dado un total de 1000 horas debe de mostrar 5 semanas, 6 dias y 16 horas.

horas_totales

1. semanas = horas_totales / horas_semana
2. horas_restantes = horas_totales % horas_semana
3. dias = horas_restantes / 24
4. horas_finales = horas_restantes % 24
*/

int hours = 1000;

int weeks = hours / 168;

int remainingHours = hours % 168;

int days = remainingHours / 24;

int finalHours = remainingHours % 24;

Console.WriteLine($"{weeks} semanas, {days} dias, {finalHours} horas");

/*
EXPLICACION DEL PROGRAMA

El programa convierte una cantidad total de horas en semanas, días y horas.

Equivalencias usadas:
1 día = 24 horas
1 semana = 7 días
1 semana = 168 horas (7 * 24)

PASO 1: Calcular semanas
weeks = hours / 168

Se divide el total de horas entre 168 para saber cuántas semanas completas hay.
Se usa división entera para que solo cuente semanas completas.

Ejemplo:
1000 / 168 = 5 semanas

PASO 2: Calcular horas restantes
remainingHours = hours % 168

El operador % (módulo) devuelve el residuo de la división.
Esto nos dice cuántas horas sobran después de quitar las semanas completas.

Ejemplo:
1000 % 168 = 160 horas restantes

PASO 3: Convertir las horas restantes en días
days = remainingHours / 24

Se divide entre 24 porque un día tiene 24 horas.

Ejemplo:
160 / 24 = 6 días

PASO 4: Calcular las horas finales
finalHours = remainingHours % 24

Se usa nuevamente el operador % para obtener las horas que sobran después de formar los días completos.

Ejemplo:
160 % 24 = 16 horas

RESULTADO FINAL:
1000 horas = 5 semanas, 6 días y 16 horas.
*/