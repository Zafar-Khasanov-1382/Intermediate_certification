﻿// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

/// <summary>
/// Метод выводит натуральные числа в промежутке от M до N
/// </summary>
/// <param name="start"> начальное значение диапазона, равное М </param>
/// <param name="end"> конечное значение диапазона, равное N </param>

void ShowNumbers (int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(M, N);
