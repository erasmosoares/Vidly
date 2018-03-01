namespace Vidly.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
       
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2b3b4b95-94ce-4fa6-a249-74a75dea98d4', N'guest@vidly.com', 0, N'AJe31lDrstqrZ+k9vge2yUSi7FoGeAQ0Uhg4ej/gmM5NcrIQmKMzX8m4tvJS07XhzQ==', N'0aa9e982-217c-44d1-b6be-ec3a877129a2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bdb99d18-eed7-4d20-86da-89c097e54000', N'admin@vidly.com', 0, N'ANtSuwkWDpALLQ3M5tjaamQZ6F67pOEmRUtI2a+Bxtyu4NCq8LVpYqKJyxtKfdqHpg==', N'a249f0ec-e9e5-4357-83d8-b92f6dc6dcff', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8a9ba102-9036-4aeb-b9b1-428a770b1933', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bdb99d18-eed7-4d20-86da-89c097e54000', N'8a9ba102-9036-4aeb-b9b1-428a770b1933')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
