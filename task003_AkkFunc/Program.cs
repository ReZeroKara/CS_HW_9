//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.

Console.WriteLine("Введите два неотрицательных числа: M, N");

int m = Readint("Введите число M: ");
int n = Readint("Введите число N: ");

Console.WriteLine($"A({m}, {n}) = {AkkermanFunc(m, n)}");

int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunc(m - 1, 1);
    else
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int Readint(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}