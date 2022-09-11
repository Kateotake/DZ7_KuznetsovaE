// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            array[i, j] = new Random().Next(10, 100);
    }
    return array;
}

string PrintVal(int [,] matr, int m, int n)
{
    if (m > matr.GetLength(0) || n > matr.GetLength(1)) 
    return $"Элемента на позиции [{m},{n}] нет";
    else return $"Значение элемента на позиции [{m},{n}] : {matr[m,n]}";
}

int[,] mas = FillArray(3, 4);
PrintArray(mas);
Console.WriteLine();
Console.WriteLine(PrintVal(mas,0,2));