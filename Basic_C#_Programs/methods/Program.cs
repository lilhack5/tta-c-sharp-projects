using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do the math operations on?");//shows on the first line of the console.
            int numUser = Convert.ToInt32(Console.Read());//allows the user to enter a number and turn it from a string to an integer.

            math mathOne = new math();
            mathOne.jesus = +5;
            mathOne.loves = -70;
            mathOne.you = +25;

            Console.WriteLine(numUser + mathOne.jesus);// takes what the user typed in and adds to mathOne.jesus
            Console.ReadLine();
            Console.WriteLine(numUser + mathOne.loves);//takes what the user typed and adds to mathOne.loves
            Console.ReadLine();
            Console.WriteLine(numUser + mathOne.you);//takes what the user typed and adds to mathOne.you
            Console.ReadLine();
        }
    }
}
