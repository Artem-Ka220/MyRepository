//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
using System;
class Exponentiation{
    static void Main(){
        Console.WriteLine("Enter the first number: ");
        int yourNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int yourNumberTwo = Convert.ToInt32(Console.ReadLine());
        
        int powerNumber = NaturalDegree(yourNumberOne, yourNumberTwo);
        
        Console.WriteLine($"The number {yourNumberOne} to the power of {yourNumberTwo} is: {powerNumber}.");
    }
    static int NaturalDegree(int one, int two){
        int count = 0;
        int degr = 1;
        while(count < two){
            degr = degr * one;
            count++;
        }
        return degr;
    }
}

