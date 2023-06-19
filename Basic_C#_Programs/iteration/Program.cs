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
            string name = Console.ReadLine();
            for (int h = 0; h < names.Length; h++)
            {
                names[h] += name;//
            }


            for (int w = 0; w < names.Length; w++)
            {
                Console.WriteLine(names[w]);//prints the list of the array to the console.
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

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] == apex)
                {
                    Console.WriteLine("You used text already in the index" + i);// writes to the console they used text and the position in the list.
                }

                else if (!players.Contains(apex))
                {
                    Console.WriteLine("Your input is not on the list");
                    break;//pulls out of the loop
                }
            }           

            List<string> notcreative = new List<string>() { "Jesus loves you.", "Jesus loves you." };//Created identical strings.
            Console.WriteLine("Please add text to search the list.");// shows on the console
            string notCreative = Console.ReadLine();//allows the user to enter text

            for (int t = 0; t < notcreative.Count; t++)
            {
                if (notcreative[t] == notCreative)
                {
                    Console.WriteLine(t);// will show what inidici the text is on
                }

                else if (!notcreative.Contains(notCreative))
                {
                    Console.WriteLine("Your input is not on the list");// will show that your item is not on the list
                }
            }




            List<string> saves = new List<string>() { "Jesus is how to get to heaven", "Jesus saves.", "Jesus saves." };//created lindetical strings.
            List<string> heaven = new List<string>();//created an empty list


            for (int h = 0; h < saves.Count; h++)
            foreach (string save in saves)
            {
                if (!saves[h].Contains(save))//if the current element in the original list is contained in the second list

                {
                    Console.WriteLine(saves[h] + " is a duplicate.");
                }

                else
                {
                    Console.WriteLine(saves[h] + " is unique.");
                    heaven.Add(saves[h]);
                }
            }





            Console.ReadLine();
        }
    }
}
