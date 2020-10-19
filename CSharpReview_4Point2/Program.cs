﻿using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            // Declaration of a variable.
            char aChar; // A single character value.
            string aString; // String (collection of characters) values.

            bool aBoolean; // Boolean (true-false) values (bit).

            byte aByte; // Super small integer values (~120 max).
            short aShortInt; // Small integer values (~65000 max).
            int anInt; // Integer values (~210000000 max).
            long aLongInt; // BIG integer values (9223372036854775807 max).

            float aFloat; // Floating point values (less precision than doubles).
            double aDouble; // Decimal values (like a float but more precise).
            decimal aDecimal; // Also decimal values (extremely precise).


            string name;

            // Write a prompt.
            // Write will keep the cursor on the same line, WriteLine will not.
            Console.Write("Please enter your name: ");

            // Input from the console.
            name = Console.ReadLine();

            // Output to the console.
            // Concatenation.
            Console.WriteLine("Hello "+name+"! What a nice day today!");
            // Parameterized Output.
            Console.WriteLine("Hello {0}! What a nice day today!", name);
            // String Interpolation.
            Console.WriteLine($"Hello {name}! What a nice day today!");

            // Exit point of programs in C#.
        }
    }
}
