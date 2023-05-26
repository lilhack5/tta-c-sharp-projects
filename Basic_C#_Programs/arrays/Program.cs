using System;
using System.Collections.Generic;


namespace arrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please pick 1 of these numbers: 0, 1, 2");// when the program starts this is the first line that will appear.
            string[] names = { "Billy", "Bob", "Joe" };// created a string array of names.
            string pick = Console.ReadLine();//
            int pickNum = Convert.ToInt32(pick);
            Console.WriteLine(names[pickNum]);

            Console.WriteLine("Please pick 1 of these numbers: 0, 1, 2");//this will show up after the first question has been answered.
            int[] num = { 5, 55, 555 };//created an array of integers.
            int number = Convert.ToInt32(Console.ReadLine());//allows the user to pick a number and converts it from a string to an integer.
            
            if (number < 3)
            {
                Console.WriteLine(num[number]);//will show one of thee integers from the array.
            }
            else
            {
                Console.WriteLine("You picked a wrong number.");//will show if the user picked a number outside of the range set.
            }

            Console.WriteLine("Please pick 1 of these numbers: 0, 1, 2");//this will show up after the second question has been answered.
            List<string> intList = new List<string>();//created a new list
            intList.Add("Baseball");//added to the list.
            intList.Add("Apex");
            intList.Add("Sleep");
            int listNum = Convert.ToInt32(Console.ReadLine());//allows user to pick a number for the index.
            Console.WriteLine(intList[listNum]);//will show what is in the index spot that the user picked



            Console.Read();
        }
    }
}
