// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
using System;
class Solution
{
    static void Main()
    {
        int[,] array = CreateNewArray(5, 5);
        PrintArray(array);
        SwapStringArray(array);
    }

    static int[,] CreateNewArray(int height, int width)
    {
        int[,] newArrays = new int[height, width];
        for (int i = 0; i < newArrays.GetLength(0); i++)
        {
            for (int j = 0; j < newArrays.GetLength(1); j++)
            {
                newArrays[i, j] = new Random().Next(-14, 14);
            }
        }
        return newArrays;
    }
    static void PrintArray(int[,] anyArray)
    {
        for (int i = 0; i < anyArray.GetLength(0); i++)
        {
            for (int j = 0; j < anyArray.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write("[");
                }
                if (j < anyArray.GetLength(1) - 1)
                {
                    Console.Write($"{anyArray[i, j],3},");
                }
                else
                {
                    Console.Write($"{anyArray[i, j],3} ]");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void SwapStringArray(int[,] anyArray)
    {
        int[,] myNewArray = new int[anyArray.GetLength(0), anyArray.GetLength(1)];
        if (anyArray.GetLength(0) - 1 != anyArray.GetLength(1) - 1)
        {
            Console.WriteLine("The two-dimensional array is not square.");
            Console.WriteLine();
        }
        else
        {
            for (int i = anyArray.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < anyArray.GetLength(1); j++)
                {
                    myNewArray[i, j] = anyArray[j, i];
                }
            }
            PrintArray(myNewArray);
        }

    }
}
