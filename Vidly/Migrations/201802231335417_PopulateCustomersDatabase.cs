namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersDatabase : DbMigration
    {
        public override void Up()
        {
           // Sql("SET IDENTITY_INSERT Customers ON");
           // Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter,MembershipTypeId,Birthdate) VALUES (1, 'Erasmo Soares','true','1',08/12/1986)");
           // Sql("SET IDENTITY_INSERT Customers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
