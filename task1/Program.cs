//  Задача1. Напишите программу , которая на вход принимает два числа и проверяет
// является ли первое первочисло квадратом второго

// Например:
// 5 -> 25 -> да
// 2 -> 10 -> нет
// -3 -> 9 -> да
// 9 -> -3 -> нет

Console.Write("Введите переменную a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите переменную b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("да");
}

else
{
    Console.WriteLine("нет");
}