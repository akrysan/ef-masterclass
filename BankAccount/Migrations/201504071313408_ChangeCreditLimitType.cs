namespace BankAccount.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCreditLimitType : DbMigration
    {
        public override void Up()
        {
            Sql("update dbo.Accounts set CreditLimit=0");
            AlterColumn("dbo.Accounts", "CreditLimit", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "CreditLimit", c => c.Int());
        }
    }
}
