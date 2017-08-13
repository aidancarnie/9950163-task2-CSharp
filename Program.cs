using System;

namespace _9950163_task2_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variable for numbers
            var num = 0;
            
            Console.WriteLine("This program will compute the average of 10 numbers");

            for (var i = 0; i < num; i++)
            {
                //set calculation for average
                var sum = num / 10;
                //ask user to enter numbers
                Console.WriteLine("Enter number 01: ");
                //store the users input
                Console.ReadLine();

                //output the average of the numbers
                Console.WriteLine("The average of those 10 numbers is: ", sum);
            }
            Console.ReadLine();
        }
    }
}
