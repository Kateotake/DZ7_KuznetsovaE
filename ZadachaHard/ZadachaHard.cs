// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

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
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

int[,] SortArray(int[,] matr)
{
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                for (int n = 0; n < matr.GetLength(1); n++)
                {
                    if (matr[i, j] < matr[k,n])
                    {
                        min = matr[k, n];
                        matr[k,n] = matr[i, j];
                        matr[i, j] = min;
                    }
                }
            }
        }
    }
    return matr;
}

int[,] mas = FillArray(3, 4);
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(SortArray(mas));