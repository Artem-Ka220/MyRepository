// Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.
// 4; [6, 7, 19, 345, 3] -> нет.
// 3; [6, 7, 19, 345, 3] -> да.
using System;
class Solution{
    static void Main(){
        int[] myArray = CreateArray(7, 0, 15);
        EnumerateArray(myArray);
        Console.WriteLine();
        FindNumber(myArray, 8);
    }
    static int[] CreateArray(int size,int max, int min){
        Random random = new Random();
        int [] array = new int[size];
        for(int i = 0; i < array.Length; i++){
            array[i] = random.Next(max,min);
        }
        return array;
    }
    static void EnumerateArray(int [] array){
        for(int i = 0; i < array.Length; i++){
            if(i == 0){
                Console.Write("[");
            }
            if(i < array.Length - 1){
                Console.Write(array[i] + ", ");
            }else{
                Console.Write(array[i] + "]");
            }
        }
    }
    static void FindNumber(int [] anyArray, int anyNomber){
        for(int i = 0; i < anyArray.Length; i++){
            if(anyArray[i] == anyNomber){
                Console.Write("Да.");
                break;
            }else{
                Console.Write("Нет.");
                break;
            }
        }
    }
}