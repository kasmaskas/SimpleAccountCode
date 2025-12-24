
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

// User's money.
decimal totalMoney = 0;

Console.WriteLine($"Welcome!\nMoney: {totalMoney}");

while (true)

{   // Main menu.
    Console.WriteLine(@"""  
    1-Deposit Money
    2-Withdraw Money 
    3-Account
    4-Quit
    """);

    // User's choice of action.
    int userInput;

    // Being sure that user enters a integer and in range.
    while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || 4 < userInput)
    {
        Console.WriteLine("Invalid input! Please only enter specified numbers!");
    }

    // Deposit action.
    if (userInput == 1)
    {
        while (true)
        {
            Console.WriteLine("Please enter the amount you want to deposit: ");
            Console.WriteLine("Enter 0 to return main menu");

            // Being sure that user enters a integer and in range.
            decimal amountDeposited;
            while (!decimal.TryParse(Console.ReadLine(), out amountDeposited))
            {
                Console.WriteLine("Please enter only the amount you want to deposit: ");
            }

            if (amountDeposited == 0)
            {
                break;
            }

            Console.WriteLine($"You entered {amountDeposited}\n Do you approve ?\n1-Yes\n2-No");

            // Users choice of approval.
            int userAnswerDeposit;

            // Being sure that user enters a integer and in range.
            while (!int.TryParse(Console.ReadLine(), out userAnswerDeposit) || userAnswerDeposit < 1 || userAnswerDeposit > 2)
            {
                Console.WriteLine("Invalid input, please enter specified input value!");
            }

            if (userAnswerDeposit == 1)
            {
                totalMoney = totalMoney + amountDeposited;
                Console.WriteLine("Your money succesfully deposited.");
                break;
            }
            else
            {
                Console.WriteLine("Operation cancelled!");
                continue;
            }
        }

    }

    // Withdraw action.
    else if (userInput == 2)
    {
        while (true)
        {
            Console.WriteLine("Please enter the amount you want to withdraw: ");
            Console.WriteLine("Enter 0 to return main menu");

            // Being sure that user enters a integer and in range.
            decimal amountWithdrawed;
            while (!decimal.TryParse(Console.ReadLine(), out amountWithdrawed))
            {
                Console.WriteLine("Please enter only the amount you want to withdraw: ");
            }

            // Being sure that requested withdrawal not greater than account balance.
            if (totalMoney < amountWithdrawed)
            {
                Console.WriteLine("Not enough deposited!");
                continue;
            }
            else if (amountWithdrawed == 0)
            {
                break;
            }

            Console.WriteLine($"You entered {amountWithdrawed}\n Do you approve ?\n1-Yes\n2-No");

            // User' choice of approval.
            int userAnswerWithdraw;

            // Being sure that user enters a integer and in range.
            while (!int.TryParse(Console.ReadLine(), out userAnswerWithdraw) || userAnswerWithdraw < 1 || userAnswerWithdraw > 2)
            {
                Console.WriteLine("Invalid input, please enter specified input value!");
            }

            if (userAnswerWithdraw == 1)
            {
                totalMoney = totalMoney - amountWithdrawed;
                Console.WriteLine("You succesfully withdrawed money!.");
                break;
            }
            else
            {
                Console.WriteLine("Operation cancelled!");
                continue;
            }
        }
    }

    // Showing account balance action.
    else if (userInput == 3)
    {
        Console.WriteLine($"Account balance: {totalMoney}");
        continue;
    }

    // Program termination.
    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}