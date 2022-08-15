// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

if(x<100) {Console.WriteLine("Третий цивры числа - нет");}

else

{

while(x>=999)
{
x=x/10;
}

x=x%10;


Console.WriteLine("Третья цифра числа = "+x);

}