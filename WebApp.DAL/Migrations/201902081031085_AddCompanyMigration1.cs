namespace WebApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddInfoes",
                c => new
                    {
                        AdInfoId = c.Int(nullable: false, identity: true),
                        PhonesId = c.Int(),
                        AddfInfo = c.String(),
                    })
                .PrimaryKey(t => t.AdInfoId)
                .ForeignKey("dbo.PhoneRecs", t => t.PhonesId)
                .Index(t => t.PhonesId);
            
            CreateTable(
                "dbo.PhoneRecs",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneId);
            
            CreateTable(
                "dbo.MessageRecs",
                c => new
                    {
                        MesRecId = c.Int(nullable: false, identity: true),
                        PhonesId = c.Int(),
                        MessageId = c.Int(),
                        DateCreate = c.DateTime(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        PeriodCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MesRecId)
                .ForeignKey("dbo.PhoneRecs", t => t.PhonesId)
                .ForeignKey("dbo.UserMessages", t => t.MessageId)
                .Index(t => t.PhonesId)
                .Index(t => t.MessageId);
            
            CreateTable(
                "dbo.UserMessages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Id = c.String(maxLength: 128),
                        MessageText = c.String(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageRecs", "MessageId", "dbo.UserMessages");
            DropForeignKey("dbo.UserMessages", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.MessageRecs", "PhonesId", "dbo.PhoneRecs");
            DropForeignKey("dbo.AddInfoes", "PhonesId", "dbo.PhoneRecs");
            DropIndex("dbo.UserMessages", new[] { "Id" });
            DropIndex("dbo.MessageRecs", new[] { "MessageId" });
            DropIndex("dbo.MessageRecs", new[] { "PhonesId" });
            DropIndex("dbo.AddInfoes", new[] { "PhonesId" });
            DropTable("dbo.UserMessages");
            DropTable("dbo.MessageRecs");
            DropTable("dbo.PhoneRecs");
            DropTable("dbo.AddInfoes");
        }
    }
}
