using System;

namespace mathInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a Number to multiply by 50 with.");// Asks the user to give the app a number
            string user = Console.ReadLine();// Allows the user to input number
            int userConvert = Convert.ToInt32(user);//Converts the user from string to integer to be mulitplied
            double product = userConvert * 50;//is the math problem we have given the app
            Console.WriteLine(product);//collects the total from userConvert multiplied by  50
            

            Console.WriteLine("Give me a Number to add by 25 with.");// Asks the user to give the app a number
            string addNum = Console.ReadLine();// Allows the user to input number
            int addConvert = Convert.ToInt32(addNum);//Converts the user from string to integer to be added
            int total  = addConvert + 25;//is the math problem we have given the app
            Console.WriteLine(total);//collects the total from userConvert added by 25

            Console.WriteLine("Give me a Number to divide by 12.5.");// Asks the user to give the app a number
            string divNum = Console.ReadLine();// Allows the user to input number
            int divConvert = Convert.ToInt32(divNum);//Converts the user from string to integer to be added
            double qoutient = divConvert / 12.5;//is the math problem we have given the app
            Console.WriteLine(qoutient);//collects the total from userConvert added by 25

            Console.WriteLine("Give me a Number.");// Asks the user to give the app a number
            string num = Console.ReadLine();// Allows the user to input number
            int numConvert = Convert.ToInt32(num);//Converts the user from string to integer
            bool truefalse = numConvert > 50;
            Console.WriteLine(truefalse);

            Console.WriteLine("Give me a Number to divide by 7.");// Asks the user to give the app a number
            string remain = Console.ReadLine();// Allows the user to input number
            int remainConvert = Convert.ToInt32(remain);//Converts the user from string to integer to be added
            int remainder = remainConvert % 7;//is the math problem we have given the app
            Console.WriteLine(remainder);



            Console.Read();
        }
    }
}
