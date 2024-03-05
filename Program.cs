// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

/// <summary>
/// Метод выводит натуральные числа в промежутке от M до N
/// </summary>
/// <param name="start"> начальное значение диапазона, равное М </param>
/// <param name="end"> конечное значение диапазона, равное N </param>

// void ShowNumbers (int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }
// Console.Write("Введите начальное значение диапазона, натуральное число М: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное значение диапазона, натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

/// <summary>
/// Метод вычисляет функцию Аккермана
/// </summary>
/// <returns>
/// Значение функции Аккермана для конкретных чисел
/// </returns>

int FindAckermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FindAckermanFunction(n - 1, 1);
    }
    else
    {
        return FindAckermanFunction(n - 1, FindAckermanFunction(n, m - 1));
    }
}
Console.Write("Введите положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = FindAckermanFunction(n, m);
Console.WriteLine($"Значение функции Аккермана для чисел ({n}, {m}) составляет: {result}");

FindAckermanFunction(n, m);
