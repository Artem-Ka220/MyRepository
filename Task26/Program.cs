//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
//в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
using System;
class Sum {
  static void Main() {
    Console.WriteLine("Enter any number: ");
        int yourNum = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"The summ of the digits of {yourNum}: {SumDigits(yourNum)};");  
  }
  static int SumDigits(int anyNumber){
      int sum = 0;
      for(int i = 1; i <= anyNumber; i++){
          sum = sum + i;
      }
      return sum;
  }
}