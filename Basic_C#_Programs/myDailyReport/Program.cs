using System;


namespace myDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy"); // When program is started it wil show this line first.
            Console.WriteLine("Student Daily Report");// This will show under the 1st line.

            Console.WriteLine("What is your name?");// Asks user their name.
            string name = Console.ReadLine();// Allows user to input their name.
            Console.WriteLine("My Name is " + name + ".");// Shows what the user inputed into "name"

            Console.WriteLine("What course are you on?");// Asks what course user is on
            string course = Console.ReadLine();// Allows the user to input what course they are on
            Console.WriteLine("I am on course " + course + ".");// Show what course the user inputed

            Console.WriteLine("What page number?");// Asks the user what page number they are on
            string page = Console.ReadLine();// Allows the user to input the page they are on
            Console.WriteLine("The page is " + page + ".");// Shows what page the user inputed

            Console.WriteLine("Do you need help with anything? Please answer true or false.");//Ask the user if they need any help.
            string help = Console.ReadLine();// Allows the user to input true or false
            Console.WriteLine("Do I need help? " + help);// shows if the user needs help or not
            
            Console.WriteLine("Were there any positive feedback you'd like to provide? Please give specifics");// Asks user if there were any feedback they would like to give
            string feedback = Console.ReadLine();// Allows the user to input their feedback
            Console.WriteLine(feedback);// Shows the users feedback

            Console.WriteLine("How many hours did you study?");// Asks user how many hours they studied
            string study = Console.ReadLine();// Allows user to input the hours studied
            Console.WriteLine("I studied for " + study + " hours.");// Shows how many hours the user studied

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");// After the user answers how long they studied this will show below hours studied

            Console.Read();
        }
    }
}
