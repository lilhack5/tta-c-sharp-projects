using System;


namespace comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");// When the program is started it will show this line first.
            Console.WriteLine("Person 1");// this will show under the 1st line.

            Console.WriteLine("What is your hourly rate?");// asks user what their hourly rate is.
            string pers1 = Console.ReadLine();// allows the user to input their hourly rate.
            int pers1Num = Convert.ToInt32(pers1);// converts what the user input from string to integer.
            Console.WriteLine("My hourly rate is " + pers1Num + ".");// shows what the users hourly rate is.

            Console.WriteLine("How many hours worked per week?");// asks the user how many hours worked.
            string per1 = Console.ReadLine();// allows the user to input their hourly rate.
            int per1Week = Convert.ToInt32(per1);//converts what the user input from string to integer.
            Console.WriteLine("I worked " + per1Week + " hours.");// shows what the users hours worked per week that they entered

            Console.WriteLine("Person 2");// this will show under the 1st line.

            Console.WriteLine("What is your hourly rate?");// asks user what their hourly rate is.
            string pers2 = Console.ReadLine();// allows the user to input their hourly rate.
            int pers2Num = Convert.ToInt32(pers2);// converts what the user input from string to integer.
            Console.WriteLine("My hourly rate is " + pers1Num + ".");// shows what the users hourly rate is.

            Console.WriteLine("How many hours worked per week?");// asks the user how many hours worked.
            string per2 = Console.ReadLine();// allows the user to input their hourly rate.
            int per2Week = Convert.ToInt32(per2);//converts what the user input from string to integer.
            Console.WriteLine("I worked " + per2Week + " hours.");// shows what the users hours worked per week that they entered

            Console.WriteLine("Annual salary of Person 1:");// shows under how many hours worked for per1Num.
            double per1Annual = (pers1Num * per1Week) * 52;// multiplies the hourly rate by weekly hours worked. Then multiplied by 52 weeks for the annual salary.
            Console.WriteLine("Person 1 annual salery is " + per1Annual);// shows the annual salery for person 1.

            Console.WriteLine("Annual salary of Person 2:");// shows under how many hours worked for per2Num.
            double per2Annual = (pers2Num * per2Week) * 52;// multiplies the hourly rate by weekly hours worked. Then multiplied by 52 weeks for the annual salary.
            Console.WriteLine("Person 2 annual salery is " + per2Annual);// shows the annual salery for person 2.

            Console.WriteLine("Does Person 1 make more money than Person 2?");// asks the question who makes more money on the console.
            bool trueorfalse = per1Annual > per2Annual;// states that person 1 makes more than person 2.
            Console.WriteLine(trueorfalse.ToString());

            Console.Read();
        }
    }
}
