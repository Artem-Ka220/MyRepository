// SЗадача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
class Solution
{
    static void Main()
    {
        double[,] newArrays = MakeAnyMatrixArray(4, 4);
        PrintMyArray(newArrays);
        ArihmeticMeanElements(newArrays);
    }
    static double[,] MakeAnyMatrixArray(int height, int width)
    {
        double[,] anyArray = new double[height, width];
        for (int i = 0; i < anyArray.GetLength(0); i++)
        {
            for (int j = 0; j < anyArray.GetLength(1); j++)
            {
                anyArray[i, j] = Math.Round((new Random().NextDouble() * 10), 0);
            }
        }
        return anyArray;
    }

    static void PrintMyArray(double[,] someArray)
    {
        for (int i = 0; i < someArray.GetLength(0); i++)
        {
            for (int j = 0; j < someArray.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write("[");
                }
                if (j < someArray.GetLength(0) - 1)
                {
                    Console.Write($"{someArray[i, j],3},");
                }
                else
                {
                    Console.Write($"{someArray[i, j],3}  ]");
                }
            }
            Console.WriteLine();
        }
    }
    static void ArihmeticMeanElements(double[,] anyArray)
    {
        double[] myNewArray = new double[anyArray.GetLength(1)];
        for (int i = 0; i < anyArray.GetLength(0); i++)
        {
            for (int j = 0; j < anyArray.GetLength(1); j++)
            {

                myNewArray[j] = myNewArray[j] + anyArray[i, j];

            }
        }
        Console.Write("Sum of each column: ");
        for (int x = 0; x < myNewArray.Length; x++)
        {
            if (x < myNewArray.Length - 1)
            {
                Console.Write(myNewArray[x] + ", ");
            }
            else
            {
                Console.Write(myNewArray[x] + ".");
            }

        }
        Console.WriteLine();
        Console.Write("Arithmetic mean of each column: ");
        for (int i = 0; i < myNewArray.Length; i++)
        {
            myNewArray[i] = myNewArray[i] / anyArray.GetLength(0);
            if (i < myNewArray.Length - 1)
            {
                Console.Write(myNewArray[i] + ", ");
            }
            else
            {
                Console.Write(myNewArray[i] + ".");
            }
        }
    }
}