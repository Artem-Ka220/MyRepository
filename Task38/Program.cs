// Напишите программу, которая будет преобразовывать десятичное число
// в двоичное.
using System;
class Example
{
    static void Main()
    {
        int anyNomber = Convert.ToInt32(Console.ReadLine());
        string tobinary = ToBinary(anyNomber);
        Console.WriteLine(tobinary);
    }
    static string ToBinary(int x)
    {
        char[] buff = new char[32];

        for (int i = buff.Length - 1; i >= 0; i--)
        {
            int mask = 1 << i;
            buff[31 - i] = (x & mask) != 0 ? '1' : '0';
        }
        return new string(buff);
    }
}
