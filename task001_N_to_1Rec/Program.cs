//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int n = Readint("Введите натуральное число: ");
int x = 1;

if (n > 0)
{
    Console.WriteLine(IntervalOfNumbers(n, x));
}
else
{
    Console.WriteLine("Не корректный ввод!");
}

int IntervalOfNumbers(int n, int x)
{
    if (n == x) return n;
    else 
    {
        Console.Write($"{IntervalOfNumbers(n, x + 1)}, ");
    }
    return x;
}

int Readint(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}