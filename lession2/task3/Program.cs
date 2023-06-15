// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateDate(int number)
{
    if(number < 1 || number > 7)
    {
        Console.WriteLine("Нет такого дня недели");
        return false;
    }
    return true;
}

int day = ReadInt("Введите цифру,обозначающую день недели > ");
if (ValidateDate(day))
{
    Console.WriteLine(day == 6 || day == 7 ? "Выходной" : "Рабочий");
}