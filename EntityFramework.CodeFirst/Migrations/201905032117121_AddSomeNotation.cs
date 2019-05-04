namespace EntityFramework.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeNotation : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "City");
            RenameTable(name: "dbo.Countries", newName: "Country");
            RenameColumn(table: "dbo.City", name: "CountryId", newName: "fk_CountryId");
            RenameIndex(table: "dbo.City", name: "IX_CountryId", newName: "IX_fk_CountryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.City", name: "IX_fk_CountryId", newName: "IX_CountryId");
            RenameColumn(table: "dbo.City", name: "fk_CountryId", newName: "CountryId");
            RenameTable(name: "dbo.Country", newName: "Countries");
            RenameTable(name: "dbo.City", newName: "Cities");
        }
    }
}
