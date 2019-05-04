namespace EntityFramework.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserVisits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserVisits",
                c => new
                    {
                        fk_CityId = c.Int(nullable: false),
                        fk_UserId = c.Int(nullable: false),
                        When = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.fk_CityId, t.fk_UserId })
                .ForeignKey("dbo.City", t => t.fk_CityId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.fk_UserId, cascadeDelete: true)
                .Index(t => t.fk_CityId)
                .Index(t => t.fk_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserVisits", "fk_UserId", "dbo.User");
            DropForeignKey("dbo.UserVisits", "fk_CityId", "dbo.City");
            DropIndex("dbo.UserVisits", new[] { "fk_UserId" });
            DropIndex("dbo.UserVisits", new[] { "fk_CityId" });
            DropTable("dbo.UserVisits");
        }
    }
}
