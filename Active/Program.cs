using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";

            // WRONG string result = myString + mySecondString;

            // int num1 = Int32.Parse(myString);
            // int num2 = Int32.Parse(mySecondString);
            // int resultInt = num1 + num2;
            int resultInt = Int32.Parse(myString) + Int32.Parse(mySecondString);

            Console.WriteLine(resultInt);
            Console.Read();
        }
    }
}
