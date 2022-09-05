// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr1 = CreateArrayRndInt(4, -10, 10);
PrintArr(arr1);
int[] CreateArrayRndInt(int n, int min, int max)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
int sum = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (i % 2 !=0)
        sum = sum + arr1[i];
}
Console.WriteLine($"{sum}");