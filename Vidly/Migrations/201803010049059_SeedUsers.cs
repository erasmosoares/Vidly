namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50d3677e-06cd-40ec-a4db-e9f6091ce1fd', N'admin@vidly.com', 0, N'AGLWhpwqFFoZWjVUEb4VeSkQnwx6Y0moEP3yo8aB397zYzGjsD6CPl2bSJeWXHyy9Q==', N'a95184c6-e490-46e4-bffa-c8ec3e8a619b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a81ea13d-5b37-4c31-a263-4c7e0b0d9a04', N'guest@vidly.com', 0, N'AEUm5E7M4sdYVi04f2Bz8fjWHoaFo9akdtlBQ2ZBEaRsIqjy2bCzWMOgaM5KEHeXEA==', N'f54a1616-c0e8-4011-895d-300dd40d7303', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8a9ba102-9036-4aeb-b9b1-428a770b1933', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'50d3677e-06cd-40ec-a4db-e9f6091ce1fd', N'8a9ba102-9036-4aeb-b9b1-428a770b1933')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
