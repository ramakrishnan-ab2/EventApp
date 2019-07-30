namespace EVENT_MANAGEMENT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        EventId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .Index(t => t.CategoryId)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Judges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JudgeName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QualificationCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QualificationId = c.Int(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId)
                .Index(t => t.QualificationId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(unicode: false),
                        QualificationId = c.Int(),
                        EventId = c.Int(),
                        EventRollNo = c.Int(nullable: false),
                        SchoolId = c.Int(),
                        PhoneNo = c.String(unicode: false),
                        FathersName = c.String(unicode: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId)
                .ForeignKey("dbo.Schools", t => t.SchoolId)
                .Index(t => t.QualificationId)
                .Index(t => t.EventId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Address = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JudgesId = c.Int(),
                        RegisterId = c.Int(),
                        Marks = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Judges", t => t.JudgesId)
                .ForeignKey("dbo.Registers", t => t.RegisterId)
                .Index(t => t.JudgesId)
                .Index(t => t.RegisterId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Username = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Type = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "RegisterId", "dbo.Registers");
            DropForeignKey("dbo.Results", "JudgesId", "dbo.Judges");
            DropForeignKey("dbo.Registers", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Registers", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Registers", "EventId", "dbo.Events");
            DropForeignKey("dbo.QualificationCategories", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.QualificationCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.EventCategories", "EventId", "dbo.Events");
            DropForeignKey("dbo.EventCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Results", new[] { "RegisterId" });
            DropIndex("dbo.Results", new[] { "JudgesId" });
            DropIndex("dbo.Registers", new[] { "SchoolId" });
            DropIndex("dbo.Registers", new[] { "EventId" });
            DropIndex("dbo.Registers", new[] { "QualificationId" });
            DropIndex("dbo.QualificationCategories", new[] { "CategoryId" });
            DropIndex("dbo.QualificationCategories", new[] { "QualificationId" });
            DropIndex("dbo.EventCategories", new[] { "EventId" });
            DropIndex("dbo.EventCategories", new[] { "CategoryId" });
            DropTable("dbo.UserLogins");
            DropTable("dbo.Results");
            DropTable("dbo.Schools");
            DropTable("dbo.Registers");
            DropTable("dbo.Qualifications");
            DropTable("dbo.QualificationCategories");
            DropTable("dbo.Judges");
            DropTable("dbo.Events");
            DropTable("dbo.EventCategories");
            DropTable("dbo.Categories");
        }
    }
}
