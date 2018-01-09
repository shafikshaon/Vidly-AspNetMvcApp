namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '12-30-2011' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
