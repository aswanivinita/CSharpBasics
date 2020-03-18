using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount("Ram", 123, 1000);
            sa.ShowBalance();
            sa.CalculateSI();
            sa.ShowBalance();
            sa.Deposit();
            sa.ShowBalance();
            sa.Withdraw();
            sa.Withdraw();
            sa.ShowBalance();
        }
    }

    abstract class Account
    {
        protected string accountHolderName;
        protected int accountNo;
        protected double balance;

        public Account(string name, int no, double bal)
        {
            accountHolderName = name;
            accountNo = no;
            balance = bal;

        }

        public void ShowBalance()
        {
            Console.WriteLine(" the account " +accountNo +" of "+accountHolderName+ " is having balance:" +balance);
        }


        public void Deposit()
        {
            Console.WriteLine("Amount to Deposit");
            int amount = int.Parse(Console.ReadLine());
            balance += amount;
        }

        public void Withdraw()
        {
            Console.WriteLine("Amount to Withdraw");
            int amount = int.Parse(Console.ReadLine());

            if (amount <= balance)
            {


                balance -= amount;
                Console.WriteLine(amount+ " is withdrawn");
            }

            else
            {
                Console.WriteLine("insufficient funds. available funds is :" +balance);
            }
        }

        public abstract void CalculateSI();
    }

    class SavingsAccount : Account
    {
        public SavingsAccount(string name, int no, double bal):base(name,no,bal)
        {

        }
        public override void CalculateSI()
        {
            double interest = (balance * 0.04);
            balance += interest;
            Console.WriteLine(interest+ " is added to your account");

        }


    }

    class FixedAccount : Account
    {
        public FixedAccount(string name, int no, double bal) : base(name, no, bal)
        {

        }
        public override void CalculateSI()
        {
            double interest = (balance * 0.08);
            balance += interest;
            Console.WriteLine(interest + " is added to your account");

        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(string name, int no, double bal) : base(name, no, bal)
        {

        }
        public override void CalculateSI()
        {
            
            Console.WriteLine("For current account interest will not be calculated");

        }
    }

}
