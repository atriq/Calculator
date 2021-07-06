using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Choose the operator(+, -, *, / ): ");
            string op = Console.ReadLine();


            Console.Write("Enter second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
            {
                double e = n1 + n2;
                Console.WriteLine("The soultion is " + e + "!");

            }
            else if (op == "-")
            {
                double e = n1 - n2;
                Console.WriteLine("The soultion is " + e + "!");
            }
            else if (op == "*")
            {
                double e = n1 * n2;
                Console.WriteLine("The soultion is " + e + "!");
            }
            else if (op == "/")
            {
                double e = n1 / n2;
                Console.WriteLine("The soultion is " + e + "!");
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }




        }
    }
}
