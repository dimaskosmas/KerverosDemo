namespace KerverosDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReceivedSignalRepositorychanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Partitions", "Customer_CustomerCode", c => c.String(maxLength: 16));
            AddColumn("dbo.Users", "Customer_CustomerCode", c => c.String(maxLength: 16));
            AddColumn("dbo.Zones", "Customer_CustomerCode", c => c.String(maxLength: 16));
            CreateIndex("dbo.Partitions", "Customer_CustomerCode");
            CreateIndex("dbo.Users", "Customer_CustomerCode");
            CreateIndex("dbo.Zones", "Customer_CustomerCode");
            AddForeignKey("dbo.Partitions", "Customer_CustomerCode", "dbo.Customers", "CustomerCode");
            AddForeignKey("dbo.Users", "Customer_CustomerCode", "dbo.Customers", "CustomerCode");
            AddForeignKey("dbo.Zones", "Customer_CustomerCode", "dbo.Customers", "CustomerCode");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zones", "Customer_CustomerCode", "dbo.Customers");
            DropForeignKey("dbo.Users", "Customer_CustomerCode", "dbo.Customers");
            DropForeignKey("dbo.Partitions", "Customer_CustomerCode", "dbo.Customers");
            DropIndex("dbo.Zones", new[] { "Customer_CustomerCode" });
            DropIndex("dbo.Users", new[] { "Customer_CustomerCode" });
            DropIndex("dbo.Partitions", new[] { "Customer_CustomerCode" });
            DropColumn("dbo.Zones", "Customer_CustomerCode");
            DropColumn("dbo.Users", "Customer_CustomerCode");
            DropColumn("dbo.Partitions", "Customer_CustomerCode");
        }
    }
}
