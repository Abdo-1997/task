namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ReceivedSamples",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        receivingSideId = c.Int(nullable: false),
                        clientId = c.Int(nullable: false),
                        recevingDate = c.DateTime(nullable: false),
                        describtion = c.String(nullable: false),
                        numberOfSamples = c.Int(nullable: false),
                        attachments = c.String(),
                        clienAttachments = c.String(),
                        sampleCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clients", t => t.clientId, cascadeDelete: true)
                .ForeignKey("dbo.ReceivingSides", t => t.receivingSideId, cascadeDelete: true)
                .Index(t => t.receivingSideId)
                .Index(t => t.clientId);
            
            CreateTable(
                "dbo.ReceivingSides",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReceivedSamples", "receivingSideId", "dbo.ReceivingSides");
            DropForeignKey("dbo.ReceivedSamples", "clientId", "dbo.Clients");
            DropIndex("dbo.ReceivedSamples", new[] { "clientId" });
            DropIndex("dbo.ReceivedSamples", new[] { "receivingSideId" });
            DropTable("dbo.ReceivingSides");
            DropTable("dbo.ReceivedSamples");
            DropTable("dbo.Clients");
        }
    }
}
