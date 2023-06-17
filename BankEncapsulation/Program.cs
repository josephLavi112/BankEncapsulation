namespace BankEncapsulation
{
    class program
    {


        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine($"Welcome to Robin U. bank!,");

            while (true)
            {
                Console.WriteLine($"please select a choice");
                Console.WriteLine("1. Depsoit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Gamble");
                Console.WriteLine("4. Exit");

                int option;
                if(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input.Enter a valid input");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter deposit amount");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid. Enter valid input");
                            continue;
                        }
                        account.Deposit(amount);
                        Console.WriteLine("Succesful Deposit");
                        break;
                    case 2:
                        Console.WriteLine($"current balance: {account.GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Thank You for banking with us!");
                        return;
                    default:
                        Console.WriteLine("Invalid. Please enter valid option");
                        break;


                }
            }

            


        }
    }
}
