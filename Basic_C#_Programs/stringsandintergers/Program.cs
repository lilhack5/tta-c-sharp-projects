using System;
using System.Collections.Generic;


namespace stringsandintergers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 5, 55, 555 };//created a new list of integers
                Console.WriteLine("Pick a number to divide each number in the list by.");//on the first line of the console this will show to the user.
                int numUser = Convert.ToInt32(Console.ReadLine());//allows the user to enter a number and converts it from a string to an integer.

                foreach (int number in numbers)
                {
                    Console.WriteLine(number / numUser);//diveds the number the user input by each indici.
                }
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);//if the user input 0 then this catch message will show
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);//if the user used a string then this will show
            }


            Console.WriteLine("You are out of the try/catch block"); // shows that you are out of the try/catch block and the program is running again.


            Console.ReadLine();
        }
    }
}
