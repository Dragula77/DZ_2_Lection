/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

System.Console.WriteLine("Введите любое число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (n < 100)
{
System.Console.WriteLine(" третьей цифры нет");
}
else
{
for (; n >= 1000; n /= 10);
System.Console.WriteLine( n % 10);
}
