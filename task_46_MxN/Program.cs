//46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    // Введите свое решение ниже
    double[,] matrix = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return matrix;
}

void PrintArray(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            // Используем интерполяцию строк для форматирования числа и символа табуляции
            Console.Write($"{matrix[i, j]:f2}\t");
        }

        Console.WriteLine();
    }
}