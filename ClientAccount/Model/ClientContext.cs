//using BankAccount.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Model
{
    public class ClientContext : DbContext
    {
        static ClientContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ClientContext, Configuration>());
        }

        public virtual DbSet<Client> Clients { get; set; }

    }
}
