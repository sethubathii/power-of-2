﻿// C# program to illustrate the 
// Math.Pow() function
using System;
class GFG
{

    // Main Method
    static public void Main()
    {

        // Find power using Math.Pow
        // 6 is base and 2 is power or
        // index or exponent of a number
        double pow_ab = Math.Pow(5, 3);

        // Print the result
        Console.WriteLine(pow_ab);

        // 3.5 is base and 3 is power or
        // index or exponent of a number
        double pow_tt = Math.Pow(2.7, 9);

        // Print the result
        Console.WriteLine(pow_tt);

        // 202 is base and 4 is power or
        // index or exponent of a number
        double pow_t = Math.Pow(400, 6);

        // Print the result
        Console.WriteLine(pow_t);
    }
}