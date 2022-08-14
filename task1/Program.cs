// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine());
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
if (number > 100)
{
    int thirddigit = number % 10;
    Console.WriteLine($"третья цифра -> {thirddigit}");
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

