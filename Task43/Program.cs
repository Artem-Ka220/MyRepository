//Task43 Задайте двумерный массив размером m на n,
//заполненый случайным числами.
using System;
class Solution
{
    static void Main()
    {
        Console.WriteLine("Enter the width of the two-dimensional array: ");
        int arrayWidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of the two-dimesional array: ");
        int arrayHeight = Convert.ToInt32(Console.ReadLine());

        int[,] someArray = CreateArray(arrayHeight, arrayWidth);
        PrintArray(someArray);
    }
    static int[,] CreateArray(int height, int width)
    {
        int[,] newArray = new int[height, width];
        Random rnd = new Random();
        int rows = newArray.GetUpperBound(0) + 1;
        int columns = newArray.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                newArray[i, j] = rnd.Next(-9, 9);
            }
        }
        return newArray;
    }
    static void PrintArray(int[,] myArray)
    {

        int rows = myArray.GetUpperBound(0) + 1;
        int columns = myArray.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j == 0)
                {
                    if (myArray[i, j] >= 0)
                    {
                        Console.Write($"[ {myArray[i, j]},");
                    }
                    else
                    {
                        Console.Write("[" + myArray[i, j] + ",");
                    }
                }
                else if (j == columns - 1)
                {
                    if (myArray[i, j] >= 0)
                    {
                        Console.Write($" {myArray[i, j]}]");
                    }
                    else
                    {
                        Console.Write(myArray[i, j] + "]");
                    }
                }
                else
                {
                    if (myArray[i, j] >= 0)
                    {
                        Console.Write($" {myArray[i, j]},");
                    }
                    else
                    {
                        Console.Write(myArray[i, j] + ",");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}