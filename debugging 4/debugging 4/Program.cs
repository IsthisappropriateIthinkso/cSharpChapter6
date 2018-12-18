
// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
    public static void Main()
    {
        const int QUIT = 999;
        int[] numbers = new int[20];
        int x;
        int num;
        double average;
        double total = 0;
        string inString;
        Console.Write("Please enter a number or " +QUIT + " to quit...");
        inString = ReadLine();
        num = Convert.ToInt32(inString);
        while ((num < numbers.Length) && num != QUIT)

        {
            numbers[num] = num;
            total += numbers[num];
            ++num;
            Write("Please enter a number or " +
               QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);
        }
        WriteLine("The numbers are:");
        for (int y = 0; y < num; ++num)
            Console.Write("{0,6}", numbers[y]);
        average = total / num;
        WriteLine("");
        WriteLine("The average is {0}", average);
    }
}