// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using System;
class Solution{
    static void Main(){
    int[]myArray = CreateArray(7,100, 800);
    PrintArray(myArray);
    Console.Write(EvenNumber(myArray));
  }
  static int[] CreateArray(int size, int min, int max){
      int[] anyArra = new int[size];
      for(int i = 0; i < size; i++){    
          anyArra[i] = new Random().Next(min,max);
      }
      return anyArra;
  }
  static void PrintArray(int[] newArray){
      for(int i = 0; i < newArray.Length; i++){
          if(i == 0){
              Console.Write("[");
          }if(i < newArray.Length - 1){
              Console.Write(newArray[i] + ", ");
          }else{
              Console.Write(newArray[i] + "]");
          }
      }
      Console.WriteLine();
  }
  static string EvenNumber(int[] someArray){
      int count = 0;
      for(int i = 0; i < someArray.Length; i++){
          if(someArray[i] % 2 == 0){
              count++;
          }
        }
        if (count == 1)
        {
            return $"In array {count} is an even number.";
        }
        else if (count < 1)
        {
            return "There are no even numbers in the array.";
        }
        else
        {
            return $"There are {count} even numbers in the array.";
        }
    }
}