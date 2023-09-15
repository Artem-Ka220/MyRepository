// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет
using System;
class Solution
{
    static void Main()
    {
        int[,] myArray = CreateNewMatrixArray(5, 5);
        FindNumber(myArray, 33, 33);
        PrintAnyMatrixArray(myArray);
    }
    static int[,] CreateNewMatrixArray(int height, int width)
    {
        Random random = new Random();
        int[,] newArray = new int[height, width];
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                newArray[i, j] = random.Next(-19, 19);
            }
        }

        return newArray;
    }
    static void PrintAnyMatrixArray(int[,] anyArray){
        for(int i = 0; i < anyArray.GetLength(0);i++){
            for(int j = 0; j < anyArray.GetLength(1); j++){
                if(j == 0){
                    Console.Write("[ ");
                }
                if(j < anyArray.GetLength(1) - 1){
                    Console.Write($"{anyArray[i,j], 3},");
                }else{
                    Console.Write($"{anyArray[i,j], 3} ]");
                }
            }
            Console.WriteLine();
        }
    }
    static void FindNumber(int[,] array, int anyNomberOne, int anyNomberTwo)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (anyNomberOne - 1 == i && anyNomberTwo - 1 == j)
                {
                    Console.WriteLine(array[i, j]);
                    return;
                }
                if(i == array.GetLength(0) - 1 && j == array.GetLength(1) - 1){
                    Console.WriteLine("There is no such element.");
                }
            }
        }
        Console.WriteLine();
    }
}
