namespace KerverosDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerCode = c.String(nullable: false, maxLength: 16),
                        Name = c.String(nullable: false, maxLength: 60),
                        Address = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.CustomerCode);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventCode = c.String(nullable: false, maxLength: 10),
                        Description = c.String(nullable: false, maxLength: 80),
                        ReffersTo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.EventCode, unique: true, name: "EventCodeIdx");
            
            CreateTable(
                "dbo.Partitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(nullable: false, maxLength: 16),
                        ZoneCode = c.Int(nullable: false),
                        PartitionCode = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerCode, cascadeDelete: true)
                .Index(t => t.CustomerCode);
            
            CreateTable(
                "dbo.ReceivedSignals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(nullable: false, maxLength: 16),
                        ReceivedAt = c.DateTime(nullable: false),
                        EventCode = c.String(nullable: false, maxLength: 10),
                        PartitionCode = c.Int(nullable: false),
                        ZoneCode = c.Int(),
                        UserCode = c.Int(),
                        Description = c.String(nullable: false, maxLength: 150),
                        RawData = c.String(nullable: false),
                        ReffersTo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.CustomerCode, t.EventCode }, name: "CustomerEventIdx");
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(nullable: false, maxLength: 16),
                        UserCode = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 60),
                        Phone = c.String(nullable: false, maxLength: 20),
                        MobilePhone = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 30),
                        MobileEmail = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerCode, cascadeDelete: true)
                .Index(t => t.CustomerCode);
            
            CreateTable(
                "dbo.Zones",
                c => new
                    {
                        CustomerCode = c.String(nullable: false, maxLength: 16),
                        ZoneCode = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => new { t.CustomerCode, t.ZoneCode })
                .ForeignKey("dbo.Customers", t => t.CustomerCode, cascadeDelete: true)
                .Index(t => t.CustomerCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zones", "CustomerCode", "dbo.Customers");
            DropForeignKey("dbo.Users", "CustomerCode", "dbo.Customers");
            DropForeignKey("dbo.Partitions", "CustomerCode", "dbo.Customers");
            DropIndex("dbo.Zones", new[] { "CustomerCode" });
            DropIndex("dbo.Users", new[] { "CustomerCode" });
            DropIndex("dbo.ReceivedSignals", "CustomerEventIdx");
            DropIndex("dbo.Partitions", new[] { "CustomerCode" });
            DropIndex("dbo.EventTypes", "EventCodeIdx");
            DropTable("dbo.Zones");
            DropTable("dbo.Users");
            DropTable("dbo.ReceivedSignals");
            DropTable("dbo.Partitions");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Customers");
        }
    }
}
