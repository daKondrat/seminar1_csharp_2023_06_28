// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите число =>");
string imputedString = Console.ReadLine();
int number = Convert.ToInt32(imputedString);

if (number % 2 == 0)
{
    System.Console.WriteLine("Введённое число - чётное");
}
else
{
    System.Console.WriteLine("Введённое число - нечётное");
}