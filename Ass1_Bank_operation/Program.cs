using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Solution
{
    internal class Ass1
    {


        static void Main(string[] args)
        {
            char ch;

            double amt = 5000;
            double deposite = 0, withdrwal = 0;
            Console.WriteLine("Welcome to NetBanking");
            Console.WriteLine("1.Deposite Amount \n 2.Withdrawal Amount\n 3.To check the Balance\n");
            #region credentials
            //Console.WriteLine("Enter username:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your password");
            //int password = Convert.ToInt32(Console.ReadLine()); 
            #endregion
            do
            {
                Console.WriteLine("Enter your choice:");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter amount to be deposited :");
                        deposite = Convert.ToDouble(Console.ReadLine());
                        amt = amt + deposite;
                        Console.WriteLine("Amount credited to your account,balance:{0}", amt);

                        break;

                    case 2:
                        Console.WriteLine("Enter amount you want to withdrawal :");
                        withdrwal = Convert.ToDouble(Console.ReadLine());
                        amt = amt - withdrwal;
                        Console.WriteLine(" Amount debited from your account,balance is:{0}", amt);
                        break;

                    case 3:
                        Console.WriteLine("Your Balance:{0}", amt);
                        break;

                    default:
                        Console.WriteLine("Enter  choice between 1 to 3");
                        break;
                }
                Console.WriteLine("Do you want to continue y/n");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
        }
    }
}
