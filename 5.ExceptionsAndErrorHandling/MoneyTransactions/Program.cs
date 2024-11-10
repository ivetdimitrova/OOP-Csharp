using System.Security.Principal;

namespace MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankAccounts = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, double> balanceByAccount = new Dictionary<string, double>();

            for (int i = 0; i < bankAccounts.Length; i++)
            {
                string[] account = bankAccounts[i].Split('-',StringSplitOptions.RemoveEmptyEntries);

                balanceByAccount.Add(account[0], double.Parse(account[1]));
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                string action = command[0];
                string account = command[1];
                double sum = double.Parse(command[2]);

                try
                {
                    switch (action)
                    {
                        case "Deposit":

                            if (IsValidAccount(account, balanceByAccount))
                                balanceByAccount[account] += sum;
                            break;
                        case "Withdraw":
                            if (IsValidAccount(account, balanceByAccount) &&
                                IsLowerThanBalance(sum, balanceByAccount[account]))
                                balanceByAccount[account] -= sum;
                            break;
                        default:
                            throw new ArgumentException("Invalid command!");

                    }

                    Console.WriteLine($"Account {account} has new balance: {balanceByAccount[account]:f2}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Enter another command");
            }
        }

        private static bool IsLowerThanBalance(double sum, double balance)
        {
            if (sum > balance)
            {
                throw new ArgumentException("Insufficient balance!");
                return false;
            }
               
            return true;
        }

        private static bool IsValidAccount(string account, Dictionary<string, double> balanceByAccount)
        {
            if (!balanceByAccount.ContainsKey(account))
            {
                throw new ArgumentException("Invalid account!");
                return false;
            }


            return true;
        }
    }
}
