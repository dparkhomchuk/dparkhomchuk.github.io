namespace AuthorizationPrototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationAvail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "AvailabilityType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "AvailabilityType");
        }
    }
}
