using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class DebugSix01
{
   static void Main()
   {
      string[] items = {"Belt", "Tie", "Scarf", "Cufflinks"};
      double[] prices = {29.00, 35.95, 18.50, 112.99};
        WriteLine("Items for sale:");
        Console.WriteLine("");
        for (int x = 0; x < 4; x++)
        {
  
            WriteLine("{0} for {1}",
          items[x], prices[x].ToString("C"));
        }
       
   }
}
