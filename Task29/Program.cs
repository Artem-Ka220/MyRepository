// Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2].

using System;
class Solution {
    static void Main(){
        int [] newArray = {-1, -2, 4, 5, -7, -8, 9, 23, 0};
        printArray(newArray);
        int[] myArray = ReplaceDigit(newArray);
        printArray(myArray);
    }
    static int[] ReplaceDigit(int [] anyArray){
        for(int i = 0; i < anyArray.Length; i++){
                anyArray[i] = anyArray[i] * (-1);
        }
        return anyArray;
    }
    static void printArray(int[] array){
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
        Console.WriteLine();
    }
}
