// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
using System;
class Solution{
    static void Main(){
        Console.WriteLine("Specify the size of the array: ");
        int sizeArray = Convert.ToInt32(Console.ReadLine());
        double[] AnyNewArray = CreateAnyArray(sizeArray);
        PrintAnyArray(AnyNewArray);
        Console.WriteLine($"The difference between maximum and minimum numbers is: {Difference(AnyNewArray)}.");
    }
    static double[] CreateAnyArray(int size){
        double[] MyNewArray = new double[size];
        for(int i = 0; i < MyNewArray.Length; i++){
            MyNewArray[i] = Math.Round((new Random().NextDouble() * 10),1);
        }
        return MyNewArray;
    }
    static void PrintAnyArray(double[]someArray){
        for(int i = 0; i < someArray.Length; i++){
            if(i == 0){
                Console.Write("[");
            }
            if(i < someArray.Length - 1){
                Console.Write(someArray[i] + ", ");
            }else{
                Console.Write(someArray[i] + "]");
            }
        }
        Console.WriteLine();
    }

static double Difference(double[] someArray){
    double max = someArray[0];
    double min = someArray[0];
    for(int i = 0; i < someArray.Length; i++){
        if(someArray[i] > max){
            max = someArray[i];
        }
        if(someArray[i] < min){
            min = someArray[i];
        }
    }
    max = max - min;
    return max;
}
}