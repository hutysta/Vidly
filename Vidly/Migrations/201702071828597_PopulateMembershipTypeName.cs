namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM MembershipTypes");
        }
        
        public override void Down()
        {
        }
    }
}
