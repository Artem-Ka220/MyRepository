// Задайте двумерный массив. Найдите элементы с чётными индексами.Замените эти элементы на их квадрат.
using System;
class Solution
{
    static void Main()
    {
        int[,] anyArray = CreateMatrixArray(3, 4);
        PrintNewArray(anyArray);
        
        int[,] someArray = ChangeEvenIndex(anyArray);
        PrintNewArray(someArray);
    }

    static int[,] CreateMatrixArray(int heightArray, int widthArray)
    {
        Random rnd = new Random();
        int[,] myNewArray = new int[heightArray, widthArray];

        for (int i = 0; i < myNewArray.GetLength(0); i++)
        {
            for (int j = 0; j < myNewArray.GetLength(1); j++)
            {
                myNewArray[i, j] = rnd.Next(-9, 9);
            }
        }
        return myNewArray;
    }

    static void PrintNewArray(int[,] someArray)
    {
        for (int i = 0; i < someArray.GetLength(0); i++)
        {
            for (int j = 0; j < someArray.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write("[");
                }
                if (j < someArray.GetLength(1) - 1)
                {
                    Console.Write($"{someArray[i, j],3}, ");
                }
                else
                {
                    Console.Write($"{someArray[i, j],3}]");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }

    static int[,] ChangeEvenIndex(int[,] newArray)
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    newArray[i, j] *= newArray[i, j];
                }
            }
        }
        return newArray;
    }
}
