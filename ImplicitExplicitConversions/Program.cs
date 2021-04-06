using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            // explicit conversion
            // cast double to int;
            // cuts off at decimal only, no rounding
            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
