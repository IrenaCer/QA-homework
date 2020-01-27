using System;

namespace QAhomework
{
    class MainClass
    {
        public static NumberList numList = new NumberList();
        public static void Main(string[] args)
        {
            try
            {
                NumberReader reader = new NumberReader(ref numList);

                Menu menu = new Menu();
                while (true)
                {
                    menu.Show();
                    States choice = menu.Choose();

                    int today = (int)DateTime.Today.DayOfWeek;

                    switch (choice)
                    {
                        case States.INPUT:
                            NumberReader.Read();

                            try
                            {
                                Console.WriteLine("Sum of integers in collection divided by number of today's day: " + numList.Divide(today));
                            } catch(OverflowException)
                            {
                                Console.WriteLine("Error. The sum of numbers exceeded largest possible value (9,223,372,036,854,775,807)");
                            }
                            
                            break;
                        case States.COUNT:
                            Console.WriteLine("There are {0} integers in the collection", numList.Count());
                            break;
                        case States.PRINT:
                            Console.WriteLine(numList.Print());
                            break;
                        case States.CLEAR:
                            numList.Clear();
                            Console.WriteLine("Collection is cleared");
                            break;
                        case States.EXIT:
                            Environment.Exit(0);
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.Write("Unknown error happened :(");
            }
        }
    }
}

