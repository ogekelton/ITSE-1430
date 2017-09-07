/*
 * Kelton Oge
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Host {
    class Program 
    {
        //
        static void Main( string[] args )
        {
            int hours;
            string name = "Kelton";

            //Concat
            name = name + "Oge";

            //Copy
            name = "Hello";

            bool areEqual = name == "Hello";
            bool areNotEqual = name != "Hello";

            //Varbatim string - no escape sequence
            string path = @"C:\Temp\test.txt";

            string names = "Kelton" + "Oge" + "Murphy" + "Charles" + "Henry";
            StringBuilder builder = new StringBuilder();
            builder.Append("Kelton");
            builder.Append("Oge");
            string names2 = builder.ToString();

            //Option 3
            string names3 = String.Concat("Kelton", "Oge", "Murphy", "Charles", "Henry");

            //String formattting
            //Kelton worked 10 hours
            string format1 = name + "worked" + hours.ToString() + "hours";

            string format2 = String.Format("{0} worked for {1} hours", name, hours);
        }
    }
}
