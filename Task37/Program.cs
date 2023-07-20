// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины.
using System;
class Solution
{
    public static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        int[] arrays = new int[3];
        arrays[0] = Convert.ToInt32(Console.ReadLine());
        arrays[1] = Convert.ToInt32(Console.ReadLine());
        arrays[2] = Convert.ToInt32(Console.ReadLine());

        CanMakeTriangle(arrays);
    }
    static void CanMakeTriangle(int[] anyArray)
    {
        int count = 0;
        for (int i = anyArray.Length - 1; i >= 0; i--)
        {
            if (i == anyArray.Length - 1)
            {
                if (anyArray[i] >= anyArray[i - 1] + anyArray[i - 2])
                {
                    Console.WriteLine("The triangle won't work!");
                    return;
                }
            }
            else if (i == 1)
            {
                if (anyArray[i] >= anyArray[i - 1] + anyArray[i + 1])
                {
                    Console.WriteLine("The triangle won't work!");
                    return;
                }
            }
            else if (i == 0)
            {
                if (anyArray[i] >= anyArray[i + 1] + anyArray[i + 2])
                {
                    Console.WriteLine("The triangle won't work!");
                    return;
                }
            }
            count++;
            if (count == 3)
            {
                Console.WriteLine("Wow! Can make a triangle!");
            }
        }
    }
}
