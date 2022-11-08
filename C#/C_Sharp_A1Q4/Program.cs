using System;

namespace BankApp
{
    class C_Sharp_A1Q4
    {
        public int accountNo = 100;
        public string name, phoneNo, city, type;
        public int balance=0, inp;

        public static void Main(string[] args)
        {
            Customer Customer1 = new Customer();
            Customer1.createAccount();
            DisplayCustomer Display1 = new DisplayCustomer();
            Console.WriteLine("Enter the choice 1.Deposite amount   2.Withdraw amount  3.Display Account details 4.Exit");
            int inp = Console.ReadLine(Convert.ToInt32());
            while(inp>4)
            {
                switch (inp)
                {
                    case 1: Customer1.Deposite(); break;
                    case 2: Customer1.Withdraw(); break;
                    case 3: Display1.display(); break;
                }
            }
        }
    }

    class Customer : C_Sharp_A1Q4
    {
        public Customer()
        {
            accountNo = accountNo+1;
        }
        public void createAccount()
        {
            Console.WriteLine("--------------Create Your Bank Account------------------");
            Console.WriteLine("Enter your name : ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your phone number : ");
            string phoneNo = Console.ReadLine();
            Console.WriteLine("Enter your city : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your choice of account 1 - Savings, 2 - Current: ");
            string typeCheck = Console.ReadLine();
            if (typeCheck=="1")
            {
                type = "Savings";
            }
            else
            {
                type = "Current";
            }
            Console.WriteLine("              Congatulations, Your Account has been created.               ");
        }

        public void Withdraw()
        {
            Console.Writeline("Enter the amount you want to withdraw :");
            int wi = Console.Readline(Convert.ToInt32());
            if (balance > 4999)
            {
                balance = balance - wi;
                Console.Writeline("Done, Balance in account :" + balance);
            }
            else
            {
                Console.Writeline("Not enough balance");
            } 
        }

        public  void Deposite()
        {
            Console.Writeline("Enter the amount you want to Deposite :");
            int wi = Console.Readline(Convert.ToInt32());
            balance = balance + wi;
            Console.Writeline("Done, Balance in account :" + balance);
        }
    }
    class DisplayCustomer : Customer
    {
        public void display()
        {
            Console.WriteLine("------------  Customer Deatails  -------------");
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Account No - " + accountNo);
            Console.WriteLine("Phone Number - " + phoneNo);
            Console.WriteLine("City - " + city);
            Console.WriteLine("Account Type - " + type);
            Console.WriteLine("Balance - " + balance);
        }
    }

}