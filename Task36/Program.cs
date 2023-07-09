// Напишите программу, которая развернет одномерный массив(последний элемент будет 
// на первом, а первый - на последнем и т.д.).
using System;
class Solution
{
    static int size;
    static void Main()
    {
        Console.Write("Set the size the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] myArray = CreateNewArray(size);
        PrintArray(myArray);
        myArray = ExplandingArray(myArray);
        PrintArray(myArray);
    }
    static int[] CreateNewArray(int length)
    {
        Random rnd = new Random();
        int[] someArray = new int[length];
        for (int i = 0; i < someArray.Length; i++)
        {
            someArray[i] = rnd.Next(1, 100);
        }
        return someArray;
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
                Console.Write(anyArray[i] + "]");
            }
        }
        Console.WriteLine();
    }

    static int[] ExplandingArray(int[] someArray)
    {
        int[] newArray = new int[someArray.Length];
        int count = 0;
        for (int i = someArray.Length - 1; i >= 0; i--)
        {
            newArray[count] = someArray[i];
            count++;
        }
        return newArray;
    }
}

