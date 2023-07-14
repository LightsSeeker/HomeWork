// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void numbers(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    numbers(m + 1, n);
}

int m = Prompt("Введите значение M > ");
int n = Prompt("Введите значение N > ");
numbers(m, n);
