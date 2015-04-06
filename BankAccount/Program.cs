using BankAccount.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AccountContext())
            {

                context.Accounts.Add(new Account() {Client = "Toyota"});
                context.Accounts.Add(new Account() { Client = "Subaru" });
                context.SaveChanges();

                var accounts = context.Accounts;

                foreach (var account in accounts)
                {
                    Console.WriteLine(account.Client);
                }
            }

            Console.ReadLine();
        }
    }
}
