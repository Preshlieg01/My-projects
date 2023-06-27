using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetique calculator");
            Console.WriteLine();
            Console.WriteLine("NB:CALCULATOR CAN ONLY USE THE FOLLOWING OPERATORS: + - * /");

            Console.WriteLine();

            // Prompt user to enter first number
            Console.Write("Please enter your number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            string inputOperator;
            bool isValidOperator = false;

            do
            {
                Console.Write("Please enter a valid operator: ");
                inputOperator = Console.ReadLine();

                if (inputOperator == "+" || inputOperator == "-" || inputOperator == "*" || inputOperator == "/")
                {
                    isValidOperator = true;
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please try again.");
                }
            } while (!isValidOperator);


            Console.WriteLine();

            Console.Write("Please enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();    

            if (inputOperator == "+")
            {
                Console.WriteLine( num1 + num2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine( num1 - num2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            Console.WriteLine();

            //converting centimeters to meters
            Console.Write("Please enter measumments in centimeter: ");
            double centimeter = Convert.ToDouble(Console.ReadLine());
            {
                Console.WriteLine();
                Console.WriteLine("Your measuments in meters: " + centimeter/100);
            }
            Console.WriteLine();

            Console.WriteLine("Thank you for using the arithmetique calculator goodbye!");
        }
    }
}