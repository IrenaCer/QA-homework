using System;
namespace QAhomework
{
    public enum States
    {
        INPUT = 1,
        COUNT,
        PRINT,
        CLEAR,
        EXIT
    }

    public class Menu
    {
        string contents = string.Format("\nMenu: \n" +
                          "[{0}] Input integers \n" +
                          "[{1}] Show count of numbers \n" +
                          "[{2}] Print all numbers \n" +
                          "[{3}] Delete all data \n" +
                          "[{4}] Exit \n", (int)States.INPUT, (int)States.COUNT, (int)States.PRINT, (int)States.CLEAR, (int)States.EXIT);

        public void Show()
        {
            Console.WriteLine(contents);
        }

        public States Choose()
        {
            Console.WriteLine("Select an option: ");
            string choice;
            choice = Console.ReadLine();
            int val;

            while (!Int32.TryParse(choice, out val) || val < 1 || val > 5)
            {
                Console.WriteLine("Incorrect input. Please enter number between 1 and 5 according to your choice");

                Console.WriteLine("Select an option: ");
                choice = Console.ReadLine();
            }

            return (States) val;
        }
    }
}
