using System;
using Herança.Entities;


namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Account acc = new Account(10, "dJ", 0);
            BussinesAccount bacc = new BussinesAccount(11, "Joao", 0, 200);

            //Upcasting

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(12, "Nelson", 10, 200);
            Account acc3 = new SavingsAccount(14, "Maria", 100, 10);


            //Downcasting
            BussinesAccount acc4 = (BussinesAccount)acc2; //conversão explicita
           
            if(acc3 is BussinesAccount) //se a acc3 for uma BussinesAccount
            {
               // BussinesAccount acc5 = (BussinesAccount)acc3;
               BussinesAccount acc5 = acc3 as BussinesAccount;
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc6 = (SavingsAccount)acc3;

                acc6.UpdateBalance();
                Console.WriteLine("Update"); 
            }
            */

            Account acc1 = new Account(1010, "Dj", 100);
            Account acc2 = new SavingsAccount(1012, "Cassio", 100, 0);

            acc1.Withdraw(10);
            acc2.Withdraw(10);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


        }
    }
}
