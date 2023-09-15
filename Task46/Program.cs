// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами 0;0 1;1 и т.д.).
using System;
class Solution
{
    static void Main()
    {
        Console.Write("Enter the height of the two-dimensional array: ");
        int anyHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width of the two-dimensional array: ");
        int anyWidth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the minimum array value: ");
        int minValueArray = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the maximum array value: ");
        int maxValueArray = Convert.ToInt32(Console.ReadLine());

        int [,] array = CreateArray(anyHeight, anyWidth, minValueArray, maxValueArray);
        PrintAnyArray(array);

        SumArray(array);
    }
    static int[,] CreateArray(int height, int width, int dotOne, int dotTwo)
    {
        Random random = new Random();
        int[,] myNewArray = new int[height, width];
        for (int i = 0; i < myNewArray.GetLength(0); i++)
        {
            for (int j = 0; j < myNewArray.GetLength(1); j++)
            {
                myNewArray[i, j] = random.Next(dotOne, dotTwo);
            }
        }
        return myNewArray;
    }
    static void PrintAnyArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write("[");
                }
                if (j < array.GetLength(1) - 1)
                {
                    Console.Write($"{array[i,j], 3},");
                }
                else
                {
                    Console.Write($"{array[i,j], 3} ]");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void SumArray(int[,] arrray){
        int sum = 0;
        for(int i = 0; i < arrray.GetLength(0); i++){
            for(int j = 0; j < arrray.GetLength(1); j++){
                if(i == j){
                    sum += arrray[i,j];
                    if(i < arrray.GetLength(0) - 1){
                    Console.Write(sum + ", ");
                    } else{
                        Console.Write(sum + ".");
                    }
                }
            }
        }
    }
}
