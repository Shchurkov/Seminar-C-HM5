// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


float[] array = new float[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

float max = array[0];
float min = array[0];


for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] < min)
            min = array[i];
    if (array[i] > max)
            max = array[i];
}
float result = max - min;
Console.WriteLine ($"Разница между максимальным и минимальным числом {result}");
