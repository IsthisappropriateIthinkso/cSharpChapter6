using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkZips
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zipCodeArray = { "52804", "54506", "40183", "13561", "13068", "13031", "13065", "13062", "13061", "14061" };
            bool isInArray;
            string zipCode;
            int i = 0;
            bool done;

            isInArray = false;

            done = false;
            while (done == false)
            {
                for (i = 0; i < zipCodeArray.Length; i++)
                {
                    Console.Write("Enter Zip code:{0} ", i + 1);
                    zipCode = Console.ReadLine();

                    if (zipCode == zipCodeArray[i])
                        isInArray = true;

                    else if(isInArray==false)
                    {
                        Console.WriteLine("{0} is in the company's area code", zipCode);
                        Console.WriteLine("ZIP CODE: {0}", zipCodeArray[i]);
                        Console.WriteLine("");
                        done = true;
                    }
                        
                    
                    if(zipCode != zipCodeArray[i])
                        isInArray = false;

                    else if(isInArray==false)
                    {
                        Console.WriteLine("{0} is not in the companys area code", zipCode);
                        Console.WriteLine("ZIP CODE IN THE AREA:{0}", zipCodeArray[i]);
                        Console.WriteLine("");
                        done = true;
                    }
                }
            }
        }
    }
}

