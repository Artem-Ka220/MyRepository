// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
using System;
class Solution
{
    static void Main()
    {
        Console.WriteLine("How many numbers do you want to enter?");
        int howMany = Convert.ToInt32(Console.ReadLine());
        int[] myArray = CreateArray(howMany);
        PrintArra(myArray);
        LessThanZerro(myArray);
    }
    static int[] CreateArray(int length)
    {
        int[] newArray = new int[length];
        int i = 0;
        while (i < newArray.Length)
        {
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            newArray[i] = yourNumber;
            i++;
        }
        return newArray;
    }

    static void PrintArra(int[] anyArray)
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
    }
    static void LessThanZerro(int[] someArray)
    {
        int count = 0;
        for (int i = 0; i < someArray.Length; i++)
        {
            if (someArray[i] < 0)
            {
                count++;
            }
        }
        Console.Write(" -> " + count);
    }
}