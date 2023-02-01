System.Console.WriteLine("Введите числоа от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
case 1: case 2: case 3: case 4: case 5:
System.Console.WriteLine("Нет");
break;
case 6: case 7:
System.Console.WriteLine("Да");
break;
}