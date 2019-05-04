namespace EntityFramework.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeBooks",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_Id, t.Book_Id })
                .ForeignKey("dbo.Employee", t => t.Employee_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Book_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.EmployeeBooks", "Employee_Id", "dbo.Employee");
            DropIndex("dbo.EmployeeBooks", new[] { "Book_Id" });
            DropIndex("dbo.EmployeeBooks", new[] { "Employee_Id" });
            DropTable("dbo.EmployeeBooks");
            DropTable("dbo.Books");
        }
    }
}
