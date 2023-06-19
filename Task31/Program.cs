// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов 
// массива,значение которых лежит в отрезке [10, 99].
using System;
class Solution
{
    static int minRange;
    static int maxRange;
    static int arraySize;
    static void Main()
    {
        Console.WriteLine("Specify the size of the array: ");
        arraySize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Specify the minimum range array: ");
        minRange = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Specify the maximum range array: ");
        maxRange = Convert.ToInt32(Console.ReadLine());
        int[] myArray = CreateArray(arraySize, minRange, maxRange);
        PrintArray(myArray);
        Console.WriteLine($"The number of numbers in the range from 10 to 99 - {FindNumbers(myArray)}.");
    }
    static int[] CreateArray(int size, int min, int max)
    {
        int[] newArray = new int[size];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = new Random().Next(min, max);
        }
        return newArray;
    }

    static void PrintArray(int[] anyArray)
    {
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("[");
            }
            if (i < anyArray.Length - 1)
            {
                Console.Write(anyArray[i] + ", ");
            }
            else
            {
                Console.WriteLine(anyArray[i] + "]");
            }
        }

    }
    static int FindNumbers(int[] anyArray)
    {
        int count = 0;
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (anyArray[i] >= 10 && anyArray[i] <= 99)
            {
               count++;
               Console.WriteLine($"{anyArray[i]} - {count}."); 
            }
        }
        return count;
    }

}