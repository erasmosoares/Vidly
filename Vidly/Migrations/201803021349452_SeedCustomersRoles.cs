namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCustomersRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8a9ba102-9036-4aeb-b9b1-428a770b1932', N'CanManageCustomers')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bdb99d18-eed7-4d20-86da-89c097e54000', N'8a9ba102-9036-4aeb-b9b1-428a770b1932')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
