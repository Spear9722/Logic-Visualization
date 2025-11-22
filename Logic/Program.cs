using System;

class Program
{

    static void Login()
    {
        string correctUsername = "Sean";
        string correctPassword = "Kamehameha!";

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if((username != correctUsername) && (password != correctPassword))
        {
            Console.Write("Invalid Input! Please Try Again!");
            Login();
        }

        Console.Write("Welcome to the System!");
    }

    static void Main(string[] args)
    {
        Login();
    }
}
