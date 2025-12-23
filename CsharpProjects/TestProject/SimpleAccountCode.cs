
using System.Reflection.Metadata;

decimal totalMoney = 0;
Console.WriteLine($"Welcome!\nMoney: {totalMoney}");

while (true)
{
    Console.WriteLine(@"""
    1-Deposit Money
    2-Withdraw Money 
    3-Account
    4-Quit
    """);

    int userInput;
    while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || 4 < userInput)
    {
        Console.WriteLine("Invalid input! Please only enter specified numbers!");
    }

    if (userInput == 1)
    {
        Console.WriteLine("Please enter the amount you want to deposit: ");

        decimal amountDeposited;
        while (!decimal.TryParse(Console.ReadLine(), out amountDeposited))
        {
            Console.WriteLine("Please enter only the amount you want to deposit: ");
        }

        Console.WriteLine($"You entered {amountDeposited}\n Do you approve ?\n1-Yes\n2-No");
        int userAnswerDeposit;
        while (!int.TryParse(Console.ReadLine(), out userAnswerDeposit) || userAnswerDeposit < 1 || userAnswerDeposit > 2)
        {
            Console.WriteLine("Invalid input, please enter specified input value!");
        }

        if (userAnswerDeposit == 1)
        {
            totalMoney = totalMoney + amountDeposited;
            Console.WriteLine("Your money succesfully deposited.");
            continue;
        }
        else
        {
            Console.WriteLine("Operation cancelled!");
            continue;
        }
    }

    else if (userInput == 2)
    {
        Console.WriteLine("Please enter the amount you want to withdraw: ");

        decimal amountWithdrawed;
        while (!decimal.TryParse(Console.ReadLine(), out amountWithdrawed))
        {
            Console.WriteLine("Please enter only the amount you want to withdraw: ");
        }

        if (totalMoney < amountWithdrawed)
        {
            Console.WriteLine("Not enough deposited!");
            continue;
        }

        Console.WriteLine($"You entered {amountWithdrawed}\n Do you approve ?\n1-Yes\n2-No");
        int userAnswerWithdraw;
        while (!int.TryParse(Console.ReadLine(), out userAnswerWithdraw) || userAnswerWithdraw < 1 || userAnswerWithdraw > 2)
        {
            Console.WriteLine("Invalid input, please enter specified input value!");
        }

        if (userAnswerWithdraw == 1)
        {
            totalMoney = totalMoney - amountWithdrawed;
            Console.WriteLine("You succesfully withdrawed money!.");
            continue;
        }
        else
        {
            Console.WriteLine("Operation cancelled!");
            continue;
        }
    }

    else if (userInput == 3)
    {
        Console.WriteLine($"Account balance: {totalMoney}");
        continue;
    }

    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}