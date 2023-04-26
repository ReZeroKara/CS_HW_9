//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int n = Readint("Введите большее натуральное число: ");
int m = Readint("Введите меньшее натуральное число: ");

if (n > 0 || m > 0)
{
    Console.WriteLine(SummOfNumbers(n, m));
}
else
{
    Console.WriteLine("Не корректный ввод!");
}

int SummOfNumbers(int n, int m)
{
    if (n == m) return n;
    else 
    {
        return m + SummOfNumbers(n, m + 1);
    }
}

int Readint(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}