//Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
//заполненный псевдослучайными числами и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

using System;
    class Solution{
        static void Main(){
            Exit(Array());
    }
    static int [] Array(){
        int [] newArray = new int[8];
        for(int i = 0; i < newArray.Length; i++){
            newArray[i] = new Random().Next(0, 11);
        }
        return newArray;
    }
    static void Exit(int [] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
    }
}
