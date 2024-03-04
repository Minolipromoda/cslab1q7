using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cslab1q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            Console.WriteLine("ATM simulator");
            Console.WriteLine("1. CHECK BALANCE");
            Console.WriteLine("2. DEPOSIT");
            Console.WriteLine("3. WITHDRAW");
            Console.WriteLine("4. EXIT");
            Console.WriteLine(" please enter your choice number");

            int operation = int.Parse(Console.ReadLine());

           switch (operation)
            {
                case 1: balance = chkBlnce(balance); break;
                case 2: balance = dpst(balance); break;
                case 3: balance= wthdrw(balance); break;
                case 4: Console.WriteLine("THANK YOU");break;
                default : Console.WriteLine("Please try again "); break;   
            }
            Console.ReadLine();
        }

        static double chkBlnce(double balance)
        {
            Console.WriteLine($"Balance : {balance}");
            return balance;
        }

        static double dpst(double balance)
        {
            Console.WriteLine("Enter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"your balance {balance}");
            Console.WriteLine($"{amount} deposited successfully ");
            return balance;
        }

        static double wthdrw(double balance)
        {
            Console.WriteLine("Enter amount to withdraw :");
            double amount = double.Parse(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("ERROR : Please try again");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"your balance {balance}");
                Console.WriteLine("Withdrawn successfully");
            }
            return balance;
        }
    }
}
