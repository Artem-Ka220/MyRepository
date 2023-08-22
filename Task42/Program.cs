// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System;
class Solution
{
    static void Main()
    {
        Console.WriteLine("Enter the value B1: ");
        double pointB1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value K1: ");
        double pointK1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value B2: ");
        double pointB2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value K2: ");
        double pointK2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(pointB1 + " " + pointK1 + " " + pointB2 + " " + pointK2);

        Intersection(pointB1, pointK1, pointB2, pointK2);
    }
    static void Intersection(double enterOne, double enterTwo, double enterThree, double enterFour)
    {
        double anyX = (enterOne - enterThree) / ((enterTwo - enterFour) * (-1));
        double anyY = enterFour * anyX + enterThree;
        Console.WriteLine(anyX + ", " + anyY);
    }
}
