// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели 1....7"); 
int x = Convert.ToInt32(Console.ReadLine());
if(x<=5) 
{
Console.WriteLine("Не выходной");
}

else
{
Console.WriteLine("Выходной");
}

