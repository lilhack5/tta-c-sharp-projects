using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Car Insurance Aproval Questionar");//shows when you first start the program
            Console.WriteLine("What is your age?");// asks the user their age
            string age = Console.ReadLine();// allows the user to input their age
            int ageConv = Convert.ToInt32(age);//converts age from string to integer
            Console.WriteLine("I am " + ageConv + ".");// shows the age of the user

            Console.WriteLine("Have you ever had a DUI? Answer yes or no");// asks user if they have had a dui
            bool dui = true; // creates dui varrible

            Console.WriteLine("How many speeding tickets do you have?");// asks the user for their previous speeding tickets.
            string tickets = Console.ReadLine();// allows the user to input the amount of tickets they have received.
            int ticketsConvert = Convert.ToInt32(tickets);// converts tickets from a string to an integer.
            Console.WriteLine("I have had " + ticketsConvert + " tickets.");// shows how many tickets user has had.

            Console.WriteLine("Qualified?");//shows the question if qualified or not.
            bool isAuthorized = (ageConv > 15 && dui== false && ticketsConvert <= 3);// checks to make sure the user is over 15, has no dui's, and 3 or less speeding tickets.
            Console.WriteLine(isAuthorized);// shows if you are qualified for insurance

            Console.Read();
        }
    }
}
