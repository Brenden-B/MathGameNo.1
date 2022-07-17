using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick any number you'd like for this game! ");
            Console.Write("Enter your number, now. ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Okay, so you've chosen {num}. ");
            Console.Write("Is that less than 100? ");   
            string response = Console.ReadLine();
            if (response == "yes" && num < 100)
            {
                Console.WriteLine("That's correct. ");
            }
            if (response == "yes" && num > 100)
            {
                Console.WriteLine("That's incorrect.");
            }
            if (response == "no" && num < 100)
            {
                Console.WriteLine("That's incorrect. ");
            }
            if (response == "no" && num > 100)
            {
                Console.WriteLine("That's correct. ");
            }
            Console.WriteLine("It's time for a new number! ");
            Console.Write("Enter your number, now. ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Alrighty. So, you've chosen {num}. ");
            Console.Write($"Is {num} an even number? ");
            response = Console.ReadLine();
            if (response == "yes" && num % 2 == 0)
            {
                Console.WriteLine("That's correct. ");
            }
            if (response == "yes" && num % 2 != 0)
            {
                Console.WriteLine("That's incorrect. ");
            }
            if (response == "no" && num % 2 == 0)
            {
                Console.WriteLine("That's incorrect");
            }
            if (response == "no" && num % 2 != 0)
            {
                Console.WriteLine("That's correct. ");
            }
            Console.WriteLine("Okay. Time for a curveball. ");
            Console.WriteLine("I need you to pick two numbers. They can be any integer value, including 0");
            Console.Write("What is the value of your first number? ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the value of your second number? ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now, I'm going to have you do some math. ");
            Console.Write("If your third number is equivalent to your first and second number added together, what is the value of your third number? ");
            var num3 = Convert.ToInt32(Console.ReadLine());
            var correctAnswer = num1 + num2;
            if (num3 == correctAnswer)
            {
                Console.WriteLine("That's correct");
            }
            if (num3 != correctAnswer)
            {
                Console.WriteLine("That's incorrect. ");
            }
            return;
        }
    }
}
