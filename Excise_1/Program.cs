//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
int current = x/10;
int y = current % 10;
Console.WriteLine("Вторая цифра числа = "+y);