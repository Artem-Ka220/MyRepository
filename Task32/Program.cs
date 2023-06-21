// Найдите произведение пар чисел. Парой считаем первый и последний элементы, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
using System;
class Solution {
  static void Main() {
  int[] mas = new int[]{12, 21, 16, 7, 10, 8};
  int[] myArray = CreateNewArray(mas);
  PrintArray(myArray); 
    }
    static int[] CreateNewArray(int[] anyArray){
       int[] newArray = new int[anyArray.Length / 2]; 
       int count = 0;
    for(int i = 0; i < anyArray.Length / 2; i++){
      
        if(i == 0){
        count = anyArray[i] * anyArray[anyArray.Length - 1];
        } else{
        count = anyArray[i] * anyArray[anyArray.Length - 1 - i];
        }
        newArray[i] = count;
    }
    return newArray;
  }
  static void PrintArray(int[] someArray){
      for(int i = 0; i < someArray.Length; i++){
        if(i == 0) {
          Console.Write("[");
        }
        if(i < someArray.Length - 1){
      Console.Write(someArray[i] + ", ");
        }else{
           Console.Write(someArray[i] + "]");
        }
  }
  }
}