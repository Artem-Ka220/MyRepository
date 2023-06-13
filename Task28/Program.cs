// Задайте массив из 12 элементов, заполненый случайными числами из промежутка
// [-9; 9].Найдите сумму положительных и отрицательных элементов массива.
using System;
class Solution
{
    static void Main()
    {
    int [] myArray = CreateArray(12, -9, 9);
    PrintArray(myArray);
    FindSumNegativeSumPositive(myArray);
}
static int[] CreateArray(int size, int min, int max) { 
int[] array = new int[size];
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(min, max);
}
return array;
}

static void PrintArray(int [] newArray)
{
    for (int j = 0; j < newArray.Length; j++)
{
    if(j == 0) {
        Console.Write("[");
    }
    if(j < newArray.Length - 1){
        Console.Write(newArray[j] + ", ");
    } else{
        Console.Write(newArray[j] + "]");
    }
 }
 Console.WriteLine();
}

static void FindSumNegativeSumPositive(int[] anyArray)
{
    int negativeSum = 0;
    int positiveSum = 0;
    for (int s = 0; s < anyArray.Length; s++)
{
    if (anyArray[s] < 0)
    {
        negativeSum = negativeSum + anyArray[s];
    }
    else
    {
        positiveSum = positiveSum + anyArray[s];
    }
}
Console.WriteLine($"The sum of negative numbers is: {negativeSum}.");
Console.WriteLine($"The sum of positive numbers is: {positiveSum}.");}
}