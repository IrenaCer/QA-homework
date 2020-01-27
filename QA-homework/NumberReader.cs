using System;
namespace QAhomework
{
    
    public class NumberReader
    {
        static NumberList numList;

        public NumberReader(ref NumberList numbers)
        {
            numList = numbers;

        }

        public static void Read()
        {
            Console.WriteLine("Input numbers with no separators one by one, pressing return button after each. Entering 0 will stop the application and print the sum of all numbers divided by a number of today's day");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0" || input == "-0") //both would parse to 0
                {
                    break;
                }

                if (Int64.TryParse(input, out long result))
                {
                    numList.Add(result);
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please enter integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807");
                }
            }
        }
    }
}
