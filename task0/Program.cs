// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Ввдедите трехзнасное число: ");
int number = int.Parse(Console.ReadLine());
void MaxDigit(int num)
{
    int firstDigit = num / 100;
    int firstpos= firstDigit * 100; 
    int thidrpos = num % 10; 
    int numberLast = (num - firstpos - thidrpos) / 10;
    Console.WriteLine($"{number} -> {numberLast}");
    
} 

MaxDigit(number);