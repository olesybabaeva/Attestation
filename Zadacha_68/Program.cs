// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. Даны 
// два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0)
{
    Console.WriteLine($"M и N должны быть неотрицательными числами");
    return;
}
else if (N < 0)
{
    Console.WriteLine($"M и N должны быть неотрицательными числами");
    return;
}
else
{
int Akkerman (int start, int end)
{
    if (start == 0) return end + 1;
    else if (end == 0 && start > 0) return Akkerman(start - 1, 1);
    else return (Akkerman(start - 1, Akkerman(start, end - 1)));
}
Console.WriteLine(Akkerman(M, N));
}