// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("Введите первое число =>");
string imputedString = Console.ReadLine();
int number = Convert.ToInt32(imputedString);

System.Console.WriteLine("Введите второе число =>");
string imputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(imputedString2);

System.Console.WriteLine("Введите третье число =>");
string imputedString3 = Console.ReadLine();
int number3 = Convert.ToInt32(imputedString3);

int max = number;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

System.Console.WriteLine($"Максимальное число из трёх введённый равно {max}");