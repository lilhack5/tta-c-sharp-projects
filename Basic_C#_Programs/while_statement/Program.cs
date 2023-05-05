using System;


namespace while_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");// shows on the console for the user to see
            int  number = Convert.ToInt32(Console.ReadLine());//allows the user to type a number
            bool isGuessed = number == 5;

            do
            {
                switch (number)
                {
                    case 55:
                        Console.WriteLine("You guessed 55. try again");// if 55 was guessed this is shown
                        Console.WriteLine("Pick a number.");
                        break;
                    case 25:
                        Console.WriteLine("You guessed 25. try again.");//if 25 is guessed then this is shown
                        Console.WriteLine("Pick a number.");
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. that is correct");// if 5 is guessed then they got it right
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("you are wrong.");//anything other than the 3 above typed this is shown
                        Console.WriteLine("Pick a number.");
                        break;
                }
            }
            while (isGuessed);

                Console.Read();
        }
    }
}
