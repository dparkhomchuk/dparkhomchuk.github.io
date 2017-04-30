namespace AuthorizationPrototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationPoints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "ToiletAvail", c => c.Int(nullable: false));
            AddColumn("dbo.Locations", "TrafficLightAvail", c => c.Int(nullable: false));
            AddColumn("dbo.Locations", "MenuAvail", c => c.Int(nullable: false));
            AddColumn("dbo.Locations", "VisualAvail", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "VisualAvail");
            DropColumn("dbo.Locations", "MenuAvail");
            DropColumn("dbo.Locations", "TrafficLightAvail");
            DropColumn("dbo.Locations", "ToiletAvail");
        }
    }
}
