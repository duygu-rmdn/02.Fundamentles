﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilomiters = meters * 0.001f;
            Console.WriteLine($"{kilomiters:f2}");
        }
    }
}
