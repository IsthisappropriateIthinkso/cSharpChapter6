using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = { 8, 5, 3, 1 };
            double[] price = { 145.00, 160.00, 180.00, 200.00 };

            int days;
            double quotedPricePerNight;
            int i;
            bool done;     
         
            Console.Write("Enter number of days: ");
            days = int.Parse(Console.ReadLine());
                   
            quotedPricePerNight = 0;
            done = false;
            i = 0;
            while (done == false)
            {
                if (days >= range[i])
                {
                    quotedPricePerNight = price[i];
                    done = true;
                }
                else
                {
                    i = i + 1;
                    if (i == range.Length)
                    {
                        done = true;
                    }
                }
            }

            if (quotedPricePerNight == 0)
            {
                Console.WriteLine("The total price, for {0} days, could not be determined", days);
            }
            else
            {
                Console.WriteLine("The total price, for {0} days, is ${1}", days,
                        days * quotedPricePerNight);
            }           
        }
    }
}
