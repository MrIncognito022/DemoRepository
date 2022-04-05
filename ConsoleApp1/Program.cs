// See https://aka.ms/new-console-template for more information
using Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Menu
            BankAccount[] bankAccounts = new BankAccount[10];
            int currentIndex = 0;
            bool choice = true;
            do
            {

                Console.WriteLine("1. Create");
                Console.WriteLine("2. PayIn");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Balance");
                Console.WriteLine("5. Show All Account");
                Console.WriteLine("6. Exit");


                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Account Title");
                            string title = Console.ReadLine();
                            bankAccounts[currentIndex] = new BankAccount(AccountType.Current) { Title = title };
                            currentIndex++;
                            Console.WriteLine("Account created Successfully");
                            Console.WriteLine("Press any Key to continue");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Your Account code");
                            int accountCode = int.Parse(Console.ReadLine());
                            for (int i = 0; i < currentIndex; i++)
                            {
                                if (bankAccounts[i].Code == accountCode)
                                {
                                    Console.WriteLine("Enter the amount to PayIn");
                                    int amount = int.Parse(Console.ReadLine());
                                    decimal amountDecimal = (decimal)amount;
                                    bankAccounts[i].PayIn(amountDecimal);
                                    Console.WriteLine($"Amount {amountDecimal} has been successfully deposit to Account code {bankAccounts[i].Code} ");
                                    Console.WriteLine("Press any Key to continue");
                                    Console.ReadKey();
                                    Console.Clear();

                                }

                            }

                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Your Account code");
                            int accountCode = int.Parse(Console.ReadLine());
                            for (int i = 0; i < currentIndex; i++)
                            {
                                if (bankAccounts[i].Code == accountCode)
                                {
                                    Console.WriteLine("Enter the amount to Withdraw");
                                    int amount = int.Parse(Console.ReadLine());
                                    decimal amountDecimal = (decimal)amount;
                                    bankAccounts[i].WithDraw(amountDecimal);
                                    Console.WriteLine($"Amount {amountDecimal} has been successfully Withdraw to Account code {bankAccounts[i].Code} ");
                                    Console.WriteLine("Press any Key to continue");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                            {
                                Console.WriteLine("Enter Account Code to get details");
                                int accountCode = int.Parse(Console.ReadLine());
                                for (int i = 0; i < currentIndex; i++)
                                {
                                    if (bankAccounts[i].Code == accountCode)
                                    {
                                        Console.WriteLine($"Title: {bankAccounts[i].Title} Code :{bankAccounts[i].Code} Balance: {bankAccounts[i].Balance} Status: {bankAccounts[i].AccountStatus}");
                                    }
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "5":
                        {
                            Console.Clear();
                            for (int i = 0; i < currentIndex; i++)
                            {
                                Console.WriteLine("Title: " + bankAccounts[i].Title + "   Account Code : " + bankAccounts[i].Code + "    Balance:" + bankAccounts[i].Balance);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "6":
                        {
                            choice = false;
                        }
                        break;
                    case "7":
                        {
                            choice = false;
                        }
                        break;
                    case "8":
                        {
                            choice = false;
                        }
                        break;
                    default:
                        choice = false;
                        break;
                }

            } while (choice);
        }
    }
}
