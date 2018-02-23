namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set name = 'Pay as You Go' where id = 1");
            Sql("update MembershipTypes set name = 'Monthly' where id = 2");
            Sql("update MembershipTypes set name = 'Quartely' where id = 3");
            Sql("update MembershipTypes set name = 'Anual' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
