// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int[,] CreateArr(int rows, int cols) {
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
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

int size = Prompt("Введите размер матриц: > ");
// int sizeB = Prompt("Введите размер матрицы B: > ");
int[,] matrixA = CreateArr(size,size);
int[,] matrixB = CreateArr(size,size);
int[,] matrixC = CreateArr(size,size);


for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
ShowArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
ShowArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
ShowArray(matrixC);