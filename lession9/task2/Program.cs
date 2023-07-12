// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// habr
// public class Solution {
//     public static String recursion(int a, int b) {
//             // основное условие задачи
//         if (a > b) {
//             // Базовый случай
//             if (a == b) {
//                 return Integer.toString(a);
//             }
//             // Шаг рекурсии / рекурсивное условие
//             return a + " " + recursion(a - 1, b);
//         } else {
//             // Базовый случай
//             if (a == b) {
//                 return Integer.toString(a);
//             }
//             // Шаг рекурсии / рекурсивное условие
//             return a + " " + recursion(a + 1, b);
//         }
//     }
//     public static void main(String[] args) {
//         System.out.println(recursion(20, 15)); // вызов рекурсивной функции
//         System.out.println(recursion(10, 15)); // вызов рекурсивной функции
//     }
// }

int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

// Console.Write("Введи N: ");
// int N = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи M: ");
// int M = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"N={N}, M={M}");
// if (M>N)
// for (int i = N; i <= M; i++)
//     Console.Write($" {i}");
// else
//     for (int i = M; i <= N; i++)
//         Console.Write($" {i}");
