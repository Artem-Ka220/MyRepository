// Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последню строки массива.
using System;
class Solution
{
    static void Main()
    {
        int[,] array = CreateNewArray(4, 4);
        PrintArray(array);
        int[,] myArray = SwapStringArray(array);
        PrintArray(myArray);
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
    static int[,] SwapStringArray(int[,] anyArray)
    {
        int[,] myNewArray = new int[anyArray.GetLength(0), anyArray.GetLength(1)];
        for (int i = 0; i < anyArray.GetLength(0); i++)
        {
            for (int j = 0; j < anyArray.GetLength(1); j++)
            {
                if (i == 0)
                {
                    myNewArray[i, j] = anyArray[anyArray.GetLength(0) - 1, j];
                }
                else if (i == anyArray.GetLength(0) - 1)
                {
                    myNewArray[i, j] = anyArray[0, j];
                }
                else
                {
                    myNewArray[i, j] = anyArray[i, j];
                }
            }
        }
        return myNewArray;
    }
}