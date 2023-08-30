//Task44 Задайте двумерный массив размером m на n,
//каждый элемент в массиве находится по формуле: Amn = m + n.
// m = 3, n = 4
//0123
//1234
//2345

using System;

class Solution{
    static void Main(){
        int  [, ] myArray = CreateMatrixArray(3,4);
        PrintMatrixArray(myArray);
    }
    static int[,] CreateMatrixArray(int height, int width){
        int [,] newArray = new int [height, width];
        for(int i = 0; i < newArray.GetLength(0); i++){
            for(int j = 0; j < newArray.GetLength(1); j++){
                newArray[i,j] = i + j;
            }
        }
        return newArray;
    }
    static void PrintMatrixArray(int[ , ] someArray){
        for(int i = 0; i < someArray.GetLength(0); i++){
            for(int j = 0; j < someArray.GetLength(1); j++){
                if(j == 0) {
                    Console.Write("[");
                }
                if(j == someArray.GetLength(1) - 1){
                    Console.Write(someArray[i, j] + "]");
                }else{
                    Console.Write(someArray[i,j] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}