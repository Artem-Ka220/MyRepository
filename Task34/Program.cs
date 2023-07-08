// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using System;
class Solution
{
    static void Main()
    {
        int[] myArray = CreateArray(7, 100, 800);
        PrintArray(myArray);
        Console.Write($"Sum of numbers in odd position: {SumEvenNumbers(myArray)}.");
    }
    static int[] CreateArray(int size, int min, int max)
    {
        int[] anyArra = new int[size];
        for (int i = 0; i < size; i++)
        {
            anyArra[i] = new Random().Next(min, max);
        }
        return anyArra;
    }
    static void PrintArray(int[] newArray)
    {
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("[");
            }
            if (i < newArray.Length - 1)
            {
                Console.Write(newArray[i] + ", ");
            }
            else
            {
                Console.Write(newArray[i] + "]");
            }
        }
        Console.WriteLine();
    }
    static int SumEvenNumbers(int[] someArray)
    {
        int sum = 0;
        for (int i = 0; i < someArray.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum = sum + someArray[i];
            }
        }
        return sum;
    }
}

