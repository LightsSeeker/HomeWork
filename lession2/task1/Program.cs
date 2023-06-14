// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validate3sign(int number)
{
    if(number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не 3-хзначное число");
        return false;
    }
    return true;
}

int digit = ReadInt("Введите 3-хзначное число > ");
if (Validate3sign(digit))
{
    int lastDigit = digit /10 % 10;
    Console.WriteLine($"Вторая цифра числа {digit} равна {lastDigit}");
}