﻿using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jagged = new string[2][];
            jagged[0] = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            jagged[1] = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("Day_names of week : " + (string.Join(",", jagged[0])));
            Console.WriteLine("Month_names of year : " + (string.Join(",", jagged[1])));
            Console.ReadKey();
        }


    }
}
