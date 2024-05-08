namespace bankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose entry:");
            Console.WriteLine("1: Create account");
            Console.WriteLine("2: Access account");
            AccountManagement newAccount = new AccountManagement();

            int userChoice = Convert.ToInt32(Console.ReadKey());

            switch (userChoice)
            {
                case 1:
                    string? customerName = Console.ReadLine();

                    newAccount.CreateAccount(customerName);
                    break;
            }
        }
    }
}
