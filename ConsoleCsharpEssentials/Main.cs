﻿using System;



class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and your age is {1} ", name, age);
        Console.Write("Enter your birthdate: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your bitrthdate is: {0} ", birthdate);
        Console.ReadLine();
    }
}