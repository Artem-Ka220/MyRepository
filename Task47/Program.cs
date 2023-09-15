// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
using System;
class Solution
{
    static void Main()
    {
        Console.Write("Enter the hieght of the two-dimensional array: ");
        int myHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width of the two-dimensional array: ");
        int myWidth = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter the minimum array value: ");
        //int minValueArray = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter the maximum array value: ");
        //int maxValueArray = Convert.ToInt32(Console.ReadLine());

        double[,] myNewArray = CreateMatrixArray(myHeight, myWidth);
        PrintAnyArray(myNewArray);
    }
    static double[,] CreateMatrixArray(int height, int width)
    {
        Random rand = new Random();
        double[,] newArray = new double[height, width];
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                newArray[i, j] = Math.Round((rand.NextDouble() * 10),2);
            }
        }
        return newArray;
    }

    static void PrintAnyArray(double[,] anyArray)
    {
        for (int i = 0; i < anyArray.GetLength(0); i++)
        {
            for (int f = 0; f < anyArray.GetLength(1); f++)
            {
                if (f == 0)
                {
                    Console.Write("[ ");
                }
                if (f < anyArray.GetLength(1) - 1)
                {
                    Console.Write($"{anyArray[i,f], 5},");
                }
                else
                {
                    Console.Write($"{anyArray[i,f], 5} ]");
                }
            }
            Console.WriteLine();
        }
    }
}