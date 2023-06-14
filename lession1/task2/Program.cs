// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());

int[] numbers = {a,b,c};                                // создаём массив из введённых чисел
int massiveSize = 3; 
int currentIndex = 0;
int max = numbers[0];
while (currentIndex < massiveSize)                      // проходим циклом по массиву, сравнивая числа с max, и меняем max, если число больше
{
if ( numbers[currentIndex] > max ) 
{
    max = numbers[currentIndex];
}
currentIndex++;
}
Console.WriteLine("Максимальное число " + max);