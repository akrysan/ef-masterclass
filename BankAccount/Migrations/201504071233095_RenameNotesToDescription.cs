namespace BankAccount.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameNotesToDescription : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Accounts", "Notes", "Description");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Accounts", "Description", "Notes");
        }
    }
}
