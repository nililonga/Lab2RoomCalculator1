using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                //declare variable
                double input1, input2, input3;
                
                //user enters values
                Console.WriteLine("Please enter length");
                input1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter width");
                input2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter height");
                input3 = double.Parse(Console.ReadLine()); 

                //calculate to find the area
                Console.WriteLine($"The area of your room is: {(input1 * input2)}");

                //calculate to find perimeter
                Console.WriteLine($"The perimeter of your room is:{(2 * input1) + (2 * input2)}");

                //calculate volume of the room 
                Console.WriteLine($"The volume of the room is:{(input1 * input2 * input3)}");

                //ask user if they would like to continue


                Console.WriteLine("Would you like to continue? (y/n)");
                answer = Console.ReadLine();
            } while (answer == "y"); 

            








        }
    }
}
