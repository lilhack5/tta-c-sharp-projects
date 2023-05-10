using System;
using System.Collections.Generic;


namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 55, 5, 25 };// created an array.


            Console.WriteLine("please pick a number 0, 1, or 2");//asks the user to pick a number and shows on the first line one the console.
            string arrayPick = Console.ReadLine();//allows the user to pick an number
            int arrayCon = Convert.ToInt32(arrayPick);//converts the string arraryPick to integer
            Console.WriteLine("Console.WriteLine(arrayCon)");

            int[] numArray1 = new int[] { 555, 55, 525 };// created an array.

            Console.WriteLine("Pick a number 0, 1, or 2.");// shows on the console for the user to see
            int number = Convert.ToInt32(Console.ReadLine());//allows the user to type a number

            if (number == numArray1[0])// if the number the user picked was zero matching the numArray1[0] then it when show the code below or index 0 = 555
            {
                Console.WriteLine(numArray1[0]);
            }


            || (number == numArray1[1])// if the number the user picked was 1 matching the numbArray1[1] then it will show the index 1 = 55
                {               
                Console.WriteLine(numArray1[1]);
                }   
            || (number == numArray1[2])// if the number the user picked was 2 matching the numbArray1[2] then is will show the index 2 = 525
                {                
                Console.WriteLine(numArray1[2]);
                }
            else //if user doesn't pick a number from above then it will show this
            {
                Console.WriteLine("You did not pick a correct number try again");
            }

            List<string> intList = new List<string>();
            intList.Add("5 is my favorite number.");
            intList.Add("Apex is the best esport out.");
            intList.Add("A knee injury ended my pro baseball career.");

            Console.WriteLine("Please pick an index of 0,1, or 2 to learn something about me.");// asks user to pick an index to the list of strings i created
            int useString = Convert.ToInt32(Console.ReadLine());//allows the user to type a number

            if (useString == intList[0])//if the user picks the index 0 then the string from index 0 will show
            {
                Console.WriteLine(intList[0]);
            }

            if (useString == intList[1])//if the user picks the index 1 then the string for index 1 will show
            {
                Console.WriteLine(intList[1]);
            }

            if (useString == intList[2])// if the user picks index 2 then the string for index 2 will show
            {
                Console.WriteLine(intList[2]);
            }



            Console.Read();
        }
    }
}
