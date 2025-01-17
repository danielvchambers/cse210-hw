using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(userName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your fav Number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        return number;
    }

    static int SquareNumber(int number)
    {
        int nsquare = number * number;
        return nsquare;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}
