// Created by: Allen Li
// Created on: Nov 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int userNumber;
        int randomNumber;

        Console.WriteLine("Do you want a positive or negative number?");
        Console.WriteLine("");

        Console.WriteLine("Enter '1' if positive or '2' if negative ");
        Console.WriteLine("");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();

        Console.WriteLine(" ");
        if (userNumber == 1)
        {
            randomNumber = rnd.Next(1, 6);
            Console.WriteLine("The random number is: " + randomNumber);
        }
        else
        {
            randomNumber = rnd.Next(-6, -1);
            Console.WriteLine("The random number is: " + randomNumber);
        }

        Console.WriteLine("\nDone.");
    }
}