using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 69;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            float f1 = 3.5f;
            float f2 = 1.337f;
            float sumF = f1 + f2;

            string myname = "Cory";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
            Console.WriteLine("The sum of " + num1  + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + sumF);
            Console.Write("Enter a string and press enter");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Press any key then press enter :");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);
            Console.ReadKey();
        }
    }
}
