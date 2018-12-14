using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;//day accumulation
            int [] arrayTemperature = new int [8];//fahrenheit, eight so I don't have division by zero issues
           

            int temperature;
            int total=0;
            int average;
            int averageMinusTemp;

            for(i = 1; i < arrayTemperature.Length; i++)
            {
                Console.WriteLine("what is the Temperature for Day {0}?", i);
                temperature = int.Parse(Console.ReadLine());
                total = total + temperature;
                average = total / i;
                averageMinusTemp = average - temperature;
                Console.WriteLine("{0}",average);
                Console.WriteLine(" How Far away the temperature ({0}) is from the average ({1})", arrayTemperature[i], averageMinusTemp);
                
            }
        }
    }
}
