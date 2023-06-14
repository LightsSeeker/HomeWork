// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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
    int lastDigit = digit % 10;
    Console.WriteLine($"Третья цифра числа {digit} равна {lastDigit}");
}