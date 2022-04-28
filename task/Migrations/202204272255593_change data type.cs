namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReceivedSamples", "sampleCost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReceivedSamples", "sampleCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
