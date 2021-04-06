using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conventions
{
    class ClientActivity
    // Pascal casing for class names "ClientActivity"
    {
        // Method name is Pascal as well
        // method arguments camel case "firstNumber"
        static void Main(string[] args)
        {
            // local variables like itemCount

            // use userControl instead of usrCtr

            // don't use numbers at the start of variable names
            int cars3 = 6;

            // Correct
            string myName;
            int lastNum;
            bool isSaved;

            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;
        }
    }
}
