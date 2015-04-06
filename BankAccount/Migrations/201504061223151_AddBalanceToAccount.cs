namespace BankAccount.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBalanceToAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Balance");
        }
    }
}
