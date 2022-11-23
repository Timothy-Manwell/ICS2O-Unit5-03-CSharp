//Created by Timothy Manwell
// Created on: Nov 2022
//
// This program sees what movies you can watch based on your age
using System;

class Program
{
    public static void Main(string[] args)
    {
        int age;

        Console.WriteLine("What Movies Can You Watch?");
        Console.Write("\nEnter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age > 13)
        {
            Console.WriteLine("\nYou can watch R rated movies.");
        }
        else if (age == 13)
        {
            Console.WriteLine("\nYou can watch pg13 rated movies");
        }
        else if (age < 13)
        {
            Console.WriteLine("\nYou can watch G rated movies.");
        }
    }
}