namespace CustomORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Time");
            DropColumn("dbo.Users", "Password");
        }
    }
}
