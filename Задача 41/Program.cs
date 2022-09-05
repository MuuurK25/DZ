// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


void CreateArrayRndInt(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(-999, 999);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < numbers.Length - 1) Console.Write(numbers[i] + ", ");
        else Console.Write(numbers[i] + "]");
    }
}
int CalcArr(int [] numbers)
{
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) count += 1;
        }
        return  count;
    }
}
Console.Write("Введите М количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateArrayRndInt(numbers);
PrintArray(numbers);
Console.WriteLine($" Введено чисел больше 0: {CalcArr(numbers)} ");