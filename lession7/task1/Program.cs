// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] CreateArr(int rows, int cols) {
    int[,] arrayD2 = new int[rows, cols];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i,j] = new Random().Next(0,255);
        }
    }
    return arrayD2;
    }

    void ShowArray(int[,] array) {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

    int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int rows = Prompt("Введите число строк > ");
int columns = Prompt("Введите число колонок > ");
ShowArray(CreateArr(rows,columns));