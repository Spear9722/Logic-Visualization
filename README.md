# 🔐 C# Console Login System

A simple username/password authentication program built in C#. This project demonstrates console input/output, conditional logic, recursion, and basic credential validation. Ideal for beginners learning C# fundamentals and method encapsulation.

## Overview
Users enter a **username** and **password**, which are validated against predefined credentials. If incorrect, the program prompts again until the correct credentials are entered. Once validated, the user gains access.

Concepts demonstrated:  
- Console input/output (`Console.ReadLine`)  
- Conditional statements (`if`)  
- Recursion to re-attempt login  
- Method encapsulation  
- Program flow control  

## Features

- Username & password input via console  
- Hardcoded credential validation  
- Retry mechanism with recursion  
- Clean structure using `Login()` method  
- Beginner-friendly and extendable  

## Code Example

```csharp
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

        if (username != correctUsername || password != correctPassword)
        {
            Console.WriteLine("Invalid Input! Please Try Again!\n");
            Login();
            return;
        }

        Console.WriteLine("Welcome to the System!");
    }

    static void Main(string[] args)
    {
        Login();
    }
}
```

## How to Run
1. Install .NET SDK (6.0+).
2. Clone the repository:
3. Navigate to the project folder:
   ```
   git clone https://github.com/your-username/your-repo.git
   ```
4. Run the program:
   ```
   dotnet run
   ```

## Future Enhancements
- Hashed password storage
- Support for multiple user accounts
- Login attempt limits and lockout timers
- File or database-based credential storage
- Replace recursion with loops for scalability
