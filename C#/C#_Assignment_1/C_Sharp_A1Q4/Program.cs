



namespace BankApp
{
    using System;
    class C_Sharp_A1Q4
    {
        
        public static void Main(string[] args)
        {
            int inp;
            void menu()
            {
                Console.WriteLine("Enter the choice 1.Deposite amount   2.Withdraw amount  3.Display Account details 4.Exit");
                inp = Convert.ToInt32(Console.ReadLine());
            }
            Customer Customer1=new Customer();
            Customer Customer2=new Customer("Rohan", "12332412", "ssda", "Savings", 101);
            Customer1.createAccount();
            Customer2.createAccount();
            menu();
            do
            {
                switch (inp)
                {
                    case 1: inp = 0; Customer1.Deposite(); break;
                    case 2: inp = 0; Customer1.Withdraw(); break;
                    case 3: inp = 0; Customer1.display(); break;
                    default: menu(); break;
                }
            } while (inp < 4);
        }
    }

   class Customer : C_Sharp_A1Q4
    {
        public int accountNo = 100;
        public string name, phoneNo, city, type;
        public int balance = 0;

        public Customer(){}
        public Customer(string name, string phoneNo, string city, string type, int accountNo)
        {
            this.name = name;
            this.phoneNo = phoneNo;
            this.city = city;
            this.type = type;
            this.accountNo = accountNo + 1;
        }
        public void createAccount()
        {
            Console.WriteLine("--------------Create Your Bank Account------------------");
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your phone number : ");
            string phoneNo = Console.ReadLine();
            Console.WriteLine("Enter your city : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your choice of account 1 - Savings, 2 - Current: ");
            string typeCheck = Console.ReadLine();
            if (typeCheck == "1")
            {
                type = "Savings";
            }
            else
            {
                type = "Current";
            }
            Console.WriteLine("              Congratulations, Your Account has been created.               ");
        }

       public void Withdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw :");
            int wi = Convert.ToInt32(Console.ReadLine());
            if (balance > wi)
            {
                balance = balance - wi;
                Console.WriteLine("Done, Balance in account :" + balance);
            }
            else
            {
                Console.WriteLine("Not enough balance");
            }
        }
       public void Deposite()
        {
            Console.WriteLine("Enter the amount you want to Deposit :");
            int wi = Convert.ToInt32(Console.ReadLine());
            balance = balance + wi;
            Console.WriteLine("Done, Balance in account :" + balance);
            Console.WriteLine();
        }
        public void display()
        {
            Console.WriteLine("------------  Customer Details  -------------");
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Account No - " + accountNo);
            Console.WriteLine("Phone Number - " + phoneNo);
            Console.WriteLine("City - " + city);
            Console.WriteLine("Account Type - " + type);
            Console.WriteLine("Balance - " + balance);
        }
    }
}
   