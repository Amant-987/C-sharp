﻿// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса нечётные,
//   и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**


using System;
using static System.Console;
Clear();

Write("Введите количество строк массива (m): ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива (n): ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[,] NewArray = ChangeArray(array);
PrintArray(NewArray);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] ChangeArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i % 2 == 1)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (j % 2 == 1)
                {
                    inArray[i, j] = inArray[i, j] * inArray[i, j];
                }
            }
        }
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}


// Clear();

// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());

// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// ChangeArray(array);
// PrintArray(array);
// WriteLine();
// PrintArray(ChangeArray(array));
// WriteLine();
// PrintArray(array);
// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//             {
//                 array[i, j] *= array[i, j];
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write($"{array[i, j]} ");
//         }
//         WriteLine();
//     }
// }