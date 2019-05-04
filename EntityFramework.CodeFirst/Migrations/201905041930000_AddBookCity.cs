namespace EntityFramework.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpBooks", "fk_bookId", "dbo.Books");
            DropPrimaryKey("dbo.Books");
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Id)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Books", "Id");
            CreateIndex("dbo.Books", "Id");
            AddForeignKey("dbo.Books", "Id", "dbo.City", "Id");
            AddForeignKey("dbo.EmpBooks", "fk_bookId", "dbo.Books", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpBooks", "fk_bookId", "dbo.Books");
            DropForeignKey("dbo.Covers", "Id", "dbo.Books");
            DropForeignKey("dbo.Books", "Id", "dbo.City");
            DropIndex("dbo.Covers", new[] { "Id" });
            DropIndex("dbo.Books", new[] { "Id" });
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Covers");
            AddPrimaryKey("dbo.Books", "Id");
            AddForeignKey("dbo.EmpBooks", "fk_bookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
