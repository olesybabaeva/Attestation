﻿// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    Console.WriteLine($"M должно быть меньше N");
    return;
}
else
{
string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "\t" + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N));
}

