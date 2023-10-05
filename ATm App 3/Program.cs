using System;
using System.Diagnostics.Eventing.Reader;

namespace ATm_App_3
{

    internal class Program
    {
        static double balance = 1000;
        static void Main(string[] args)
        {

            while (true)
            {

            Console.WriteLine("welcome to ATM  ");
            Console.WriteLine("\n __________________________ ");
            Console.WriteLine("\n 1. check your Balance ");
            Console.WriteLine("\n 2. withdraw ");
            Console.WriteLine("\n 3. Deposit ");
            Console.WriteLine("\n 4. Exit ");
            Console.WriteLine("\n __________________________ ");
            Console.WriteLine("\n choose option 1 / 2 / 3 / 4 ");

             string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CheckBalance();
                        break;

                    case "2": Withdraw();
                        break;

                    case "3": Deposit();
                        break;

                    case "4": Console.WriteLine("Good bye");
                        Environment.Exit(0);
                        break;

                    default: Console.WriteLine("Inavlide option try again");
                        break;

                }
            }
        }
        static void CheckBalance() 
        {
            Console.WriteLine($"your account balance is : ${balance}");
        }


        static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");

            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Successfully withdrew ${amount}. Your new balance is ${balance}");
                }
                else
                {
                    Console.WriteLine("no funds.");
                }
            }
            else
            {
                Console.WriteLine("try again.");
            }
        }



        static void Deposit()
        {
            Console.Write("Enter the amount to deposit: $");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. Your new balance is ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid amount.");
            }
        }

    }   
}
