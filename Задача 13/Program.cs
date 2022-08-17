// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введитe целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(number);
if (NumberText.Length > 2)
{
    Console.WriteLine(" Третья цифра -> " + NumberText[2]);
}
else
{
    Console.WriteLine(" Третьей цифры нет");
}