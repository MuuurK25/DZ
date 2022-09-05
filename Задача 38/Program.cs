// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] array = new double[10];
FillArrayRandomNumbers(array);
PrintArray(array);
double min =(array[0]);
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = (array[i]);
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
void FillArrayRandomNumbers(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
    }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
double decision = max - min;

Console.WriteLine($" Максимальное значение = {Math.Round(max, 4)}, минимальное значение = {Math.Round(min, 4)}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round(decision, 4)}");