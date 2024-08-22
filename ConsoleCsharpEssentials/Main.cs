using System;



class MainClass
{
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

    enum DayOfWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    public static void Main(string[] args)
    {

        /*
        string myName;
        myName = "Alla";
        int myAge = 35;
        bool isHavePet = true;
        float shoeSize = 38.5f;

        Console.WriteLine("Hi, I am {0}",myName);
        Console.WriteLine("I am {0} years old", myAge);
        Console.WriteLine("Do I have a pet? It is {0}",isHavePet);
        Console.WriteLine("I am wearing shoes of {0} size",shoeSize);
        Console.WriteLine(Semaphore.Green);
        Console.WriteLine("\u0023");
        double result = 5f / 2f;
        Console.WriteLine("5 / 2 = {0}", result);
        */
        Console.WriteLine("Type day number");
        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("It's {0}", day);
        Console.ReadKey();
    }
}