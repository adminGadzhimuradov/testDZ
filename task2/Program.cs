// Задача2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    Console.Write("Понедельник");
}
else if (a == 2)
{
    Console.Write("Вторник");
}


else
{
    Console.Write("Ошибка");
}