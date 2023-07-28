// Создайте программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования. 
using System;
class Solution
{
    public static void Main()
    {
        int[] array = { 14, 18, 48, 13, 88, 17, 47, 1, 65, 32 };
        PrintArray(array);

        int[] someArray = CopyArray(array);
        PrintArray(someArray);
    }

    static int[] CopyArray(int[] anyArray)
    {
        int[] yourArray = new int[anyArray.Length];
        for (int i = 0; i < anyArray.Length; i++)
        {
            yourArray[i] = anyArray[i];
        }
        return yourArray;
    }

    static void PrintArray(int[] newArray)
    {
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("[" + newArray[i] + ", ");
            }
            else if (i < newArray.Length - 1)
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
}