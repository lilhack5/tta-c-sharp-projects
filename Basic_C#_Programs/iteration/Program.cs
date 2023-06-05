using System;
using System.Collections.Generic;


namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Billy", "Bob", "Joe" };// created a string of names
            Console.WriteLine("Please enter a name.");//this will show when you start the program.
            string user = Console.ReadLine();// allows the user to enter a name.

            foreach (string name in names)
            {
                if (name == user)
                {
                    Console.WriteLine(user);//adds the users name to the array
                }
            }

            foreach (string nameLoop in names)
            {
                Console.WriteLine(nameLoop + user);//writes the array onto the console
            }

            for (int i = 0; i < 5; i++)// had i decreasing and it starting at 5 and going down it will never reach 5 so switched i-- to i++.
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine(j);
            }

            List<string> players = new List<string>() { "Sweetdreams", "Nafen", "Gild" };//created a list of my favorite apex team. nrg
            Console.WriteLine("Please write your favorite streamer.");//allows the user to enter text on the console
            string apex = Console.ReadLine();//allows the user to enter a streamer

            foreach (string player in players)           
            {
                Console.WriteLine(player);//shows index on the console
            }

            if (apex != players[0] || apex != players[1] || apex != players[2])
            {            
                Console.WriteLine("The text you input is not on the list.");//shows if the users input is not on the list
            }

            else
            {
                Console.WriteLine("You used text already in the index");                    
            }
            
            List<string> notcreative = new List<string>() { "Jesus loves you.", "Jesus loves you." };//Created identical strings.
            Console.WriteLine("Please add text to search the list.");// shows on the console
            string notCreative = Console.ReadLine();//allows the user to enter text

            if (notCreative == notcreative[0] || notCreative == notcreative[1])
            {
                Console.WriteLine(notCreative);//if the users' text matches the indices it will show on the console.
            }

            if (notCreative != notcreative[0] || notCreative != notcreative[1])
            {
                Console.WriteLine("Your input is not on the list.");//if the text the user input does not match this will show
            }

            List<string> saves = new List<string>() { "Jesus saves.", "Jesus saves." };//created indetical strings.
            
            foreach (string save in saves)
            {
                if (save == saves[0] || save == saves[1])
                    Console.WriteLine("This item in a duplicate.");//shows on the console if the text is the same.
            }



            Console.Read();
        }
    }
}
