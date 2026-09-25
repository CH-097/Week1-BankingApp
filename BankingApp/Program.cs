/*
 *  class name: Banking App
 *  Version 1
 *  Author: Meriem Harrat
 */

void BuildBankingApp()
{

    double accountBalance = 1000.0;
    // display main menu
    Console.WriteLine("Please choose an option 1 or 2:\n" +
        "1 - Deposit or withdraw funds\n" +
        "2 - View current account info\n");

    // read user input, and convert string to integer using explicit typecasting
    int choice = Convert.ToInt32(Console.ReadLine());

    //if statement
    // || logical operator means OR
    if (choice == 1 || choice == 2)
    {
        // Deposit or withdraw funds
        if (choice == 1)
        {
            Console.WriteLine("You have chosen to deposit or withdraw funds\n" +
                "Which options do you want to choose?\n" +
                "1 - Deposit\n" +
                "2 - Withdraw");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice2 == 1)
            {
                // deposit funds
                Console.WriteLine("How much do you want to deposit?\n" +
                    "Enter amount including pence using a decimal point");

                double depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original account balance was {accountBalance}");

                //account balance = account balance + deposit amount
                accountBalance += depositAmount;
                Console.WriteLine($"Your new account balance is {accountBalance}");
            }

            else if (choice2 == 2)
            {
                // withdraw funds
                Console.WriteLine("How much do you want to withdraw?\n" +
                    "Enter amount including pence using a decimal point");

                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original balance was {accountBalance}");

                //account balance = account balance - withdraw amount
                if (withdrawAmount > accountBalance)
                {
                    Console.WriteLine("Insufficient funds. Withdrawal amount exceeds account balance.");
                }
                else
                {
                    accountBalance -= withdrawAmount;
                    Console.WriteLine($"Your new account balance is {accountBalance}");
                }

            }

            else if (choice == 2)
            {
                // view current account info
                Console.WriteLine("You have chose to view current account info\n" +
                    $"Your current account balance is {accountBalance}");
            }
            else
            {
                // view current account info
                Console.WriteLine("You have chosen to view current account info");
                accountBalance = 1000.0;
                Console.WriteLine($"Your current account balance is {accountBalance}");
            }

        }
        else
        {
            // display error message
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }

    }
}
BuildBankingApp();