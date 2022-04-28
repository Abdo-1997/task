namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnamefeild : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReceivedSamples", "name", c => c.String());
            AlterColumn("dbo.ReceivedSamples", "describtion", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReceivedSamples", "describtion", c => c.String(nullable: false));
            DropColumn("dbo.ReceivedSamples", "name");
        }
    }
}
