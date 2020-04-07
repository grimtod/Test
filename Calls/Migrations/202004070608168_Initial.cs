namespace Calls.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Duration = c.Long(nullable: false),
                        Caller_Id = c.Int(nullable: false),
                        Receiver_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhoneNumbers", t => t.Caller_Id)
                .ForeignKey("dbo.PhoneNumbers", t => t.Receiver_Id)
                .Index(t => t.Caller_Id)
                .Index(t => t.Receiver_Id);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calls", "Receiver_Id", "dbo.PhoneNumbers");
            DropForeignKey("dbo.Calls", "Caller_Id", "dbo.PhoneNumbers");
            DropIndex("dbo.Calls", new[] { "Receiver_Id" });
            DropIndex("dbo.Calls", new[] { "Caller_Id" });
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Calls");
        }
    }
}
