﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int num = 1;
while (n > num)
{
    Console.WriteLine(num + 1);
    num = num + 2;
}
