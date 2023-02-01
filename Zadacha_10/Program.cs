
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
System.Console.WriteLine("Введите трехзначное число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (N < 999)
{
N = (N % 100)/10;
System.Console.WriteLine("Вторым числом является:"+N);

}
else 
{
    System.Console.WriteLine("Ошибка, введите трехзначное число!");
}