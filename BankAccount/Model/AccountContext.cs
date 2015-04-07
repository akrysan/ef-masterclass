using BankAccount.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Model
{
    public class AccountContext : DbContext
    {
        static AccountContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccountContext, Configuration>());
        }

        public virtual DbSet<Account> Accounts { get; set; }

    }
}
