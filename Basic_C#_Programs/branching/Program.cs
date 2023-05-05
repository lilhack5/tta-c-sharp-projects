using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow instructions below.");//shows on the first line of the console.

            Console.WriteLine("What is the weight of your package?");//shows under first line to ask user for information.
            string weight = Console.ReadLine();//allows the user to input the weight
            int weightConv = Convert.ToInt32(weight);//converts the string weight into an integer
            if (50 < weightConv)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");// Will show if package is over 50
                return;//closes the console
            }

            Console.WriteLine("What is the width of the package?");//asks user in the console what the width is
            string width = Console.ReadLine();//allows user to enter the width
            int widthConv = Convert.ToInt32(width);// converts the string width into an integer

            Console.WriteLine("What is the height of the package?");//asks user in the console what the height is
            string height = Console.ReadLine();//allows user to enter the height
            int heightConv = Convert.ToInt32(height);// converts the string height into an integer

            Console.WriteLine("What is the length of the package?");//asks user in the console what the length is
            string length = Console.ReadLine();//allows user to enter the length
            int lengthConv = Convert.ToInt32(length);// converts the string length into an integer

            if (50 < widthConv + heightConv + lengthConv)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");// will show if the package dimensions were over 50
            }

            int product = widthConv * heightConv * lengthConv;// multiplies the length, width and height the user gave us
            int weightProduct = product * weightConv;// multiplies the answer for product times the weight the user gave us
            int total = weightProduct / 100; 

            Console.WriteLine("Your estimated total for shipping this package is: $" + total);
            Console.WriteLine("Thank You!");


            Console.Read();
        }
    }
}
