namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MemberShipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
    }
}
