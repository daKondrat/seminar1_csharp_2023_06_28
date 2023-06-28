// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("Введите первое число =>");
string imputedString = Console.ReadLine();
int number = Convert.ToInt32(imputedString);

System.Console.WriteLine("Введите второе число =>");
string imputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(imputedString2);

if (number > number2)
{
    System.Console.WriteLine($"Максимальное число равно {number}");
}
else
{
    System.Console.WriteLine($"Максимальное число равно {number2}");
}