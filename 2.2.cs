using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        int currentNumber = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = currentNumber;
            currentNumber += 2;
          Console.WriteLine(currentNumber);
        }
    }
}