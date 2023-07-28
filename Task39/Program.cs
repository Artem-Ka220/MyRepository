// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 1 и 2.
using System;
class Fibonacci
{
    public static int anyNomber = 0;
    public static int[] myArray = new int[0];

    static void Main()
    {
        Console.WriteLine("Enter any number: ");
        int anyNomber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(anyNomber);

        myArray = new int[anyNomber + 1];
        int[] newArray = creatNewArray(myArray);
        PrintArray(newArray);
    }
    static int[] creatNewArray(int[] someNewArrray)
    {

        for (int i = 0; i < myArray.Length; i++)
        {
            if (i == 0 || i == 1)
            {
                myArray[i] = i;
            }
            else
            {
                myArray[i] = myArray[i - 1] + myArray[i - 2];
            }
        }
        return someNewArrray;
    }

    static void PrintArray(int[] someArray)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write(myArray[i] + ", ");
            }
            else if (i < myArray.Length - 1)
            {
                Console.Write(myArray[i] + ", ");
            }
            else
            {
                Console.Write(myArray[i] + ".");
            }
        }

    }
}