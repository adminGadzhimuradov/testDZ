﻿// Напишите программу, которая на вход принимает число и выдает его квадрат
// (число умножение на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int square = a * a;
Console.WriteLine("Квадрат числа равен " + square);