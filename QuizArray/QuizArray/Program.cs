using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quizValueArray = new int[4];
            int i = 0;
            bool isDecreasing;
            bool isIncreasing;
            const int MAX_QUIZ_GRADE = 100;
            const int MIN_QUIZ_GRADE = 0;
            //get user input
            

            for (i = 0; i < 4; i++)
            {
                Console.Write("Enter a Quiz Value{0}:", i+1);
                quizValueArray[i] = int.Parse(Console.ReadLine());
                while (quizValueArray[i] > MAX_QUIZ_GRADE || quizValueArray[i] < MIN_QUIZ_GRADE)
                {
                    Console.Write("Enter a Quiz Value:");
                    quizValueArray[i] = int.Parse(Console.ReadLine());
                }

            }
           



            //gather facts...
            isDecreasing = true;
            isIncreasing = true;
            for (i=1; i<4; i++)
            {
                if (quizValueArray[i] < quizValueArray[i - 1])
                    isIncreasing = false;
                if (quizValueArray[i] > quizValueArray[i - 1])
                    isDecreasing = false;
            }
            if (quizValueArray[0] == quizValueArray[3])
            {
                isIncreasing = false;
                isDecreasing = false;
            }
            //output stuff
            if (isIncreasing == true)
            {
                Console.WriteLine("Quiz Values RISING");
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("{0}", quizValueArray[i]);
                }
            }
            if (isDecreasing == true)
            {
                Console.WriteLine("Quiz Values DROPPING ");
                Console.WriteLine("You should be shooting for this");
                Array.Sort(quizValueArray);
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("{0}", quizValueArray[i]);
                }
            }
            if (isIncreasing == false && isDecreasing== false)
            {
                Console.WriteLine("Quiz Values are neither DROPPING nor RISING");
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("{0}", quizValueArray[i]);
                }
            }
        }
    }
}