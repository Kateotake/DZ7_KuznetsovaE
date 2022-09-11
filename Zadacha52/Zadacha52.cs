// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j] } ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 10);
    }
    return array;
}

void AverageColumn(int[,] matr)
{
    double sum = 0;
    double av = 0;
    int j = 0;
    while (j < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
            av = Math.Round((sum / matr.GetLength(0)),2);
        }
        Console.WriteLine($"Среднее арифметическое {j}-го столбца равно {av}");
        j++;
        sum = 0;
    }
}

int[,] mas = FillArray(3, 4);
PrintArray(mas);
Console.WriteLine();
AverageColumn(mas);