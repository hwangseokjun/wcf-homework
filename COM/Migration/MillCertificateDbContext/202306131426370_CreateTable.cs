namespace COM.Migration.MillCertificateDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mill_cert_sheets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectNo = c.String(nullable: false, maxLength: 20),
                        MillSheetNo = c.String(nullable: false, maxLength: 20),
                        DocMngNo = c.String(nullable: false, maxLength: 20),
                        IssuedDate = c.String(nullable: false, maxLength: 20),
                        ModifiedAt = c.String(),
                        CreatedAt = c.String(nullable: false, maxLength: 20),
                        IsDeleted = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.mill_cert_sheets", new[] { "CreatedAt" });
            DropTable("dbo.mill_cert_sheets");
        }
    }
}
