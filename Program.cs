using System;
using static System.Console;
class IntegerFacts
{


    static void Main()
    {
        int[] numbers = new int[20];
        out int high, low, total, average;
        string inputString = "";
        int count = 0;

        while (count < numbers.Length)
        {
            WriteLine("Enter an integer between 1 and 100: ");
            inputString = ReadLine();
            int num;
            int.TryParse(inputString, out num);
            numbers[count] = num;
            count += 1;
        }

        getFacts(numbers, out high, out low, out total, out average);
        WriteLine("Highest integer: {0}", high);
        WriteLine("Lowest integer: {0}", low);
        WriteLine("Sum of integers: {0},", total);
        WriteLine("Average of integers: {0}", average);
    }

    private static void getFacts(int[] anArray, out int hi, out int lo, out int sum, out int avg)
    {
        lo = 9999;
        hi = 0;
        sum = 0;
        avg = 0;

        foreach (int num in anArray)
        {
            if (num < lo)
                lo = num;
            if (num > hi)
                hi = num;
            sum += num;
        }
        avg = sum / anArray.Length;
    }
}