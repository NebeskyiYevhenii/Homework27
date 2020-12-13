namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MyTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        Currency = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Title = c.String(),
                        MyTransactionTypeId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.MyTransactionTypes", t => t.MyTransactionTypeId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.MyTransactionTypeId);
            
            CreateTable(
                "dbo.MyTransactionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyTransactions", "MyTransactionTypeId", "dbo.MyTransactionTypes");
            DropForeignKey("dbo.MyTransactions", "CategoryId", "dbo.Categories");
            DropIndex("dbo.MyTransactions", new[] { "MyTransactionTypeId" });
            DropIndex("dbo.MyTransactions", new[] { "CategoryId" });
            DropTable("dbo.MyTransactionTypes");
            DropTable("dbo.MyTransactions");
            DropTable("dbo.Categories");
        }
    }
}
