namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKontaktTelefon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KontaktTelefons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipKontaktTelefona = c.String(),
                        BrKontaktTelefona = c.Double(nullable: false),
                        Lokal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Osobas", "KontaktTelefonID", c => c.Byte(nullable: false));
            AddColumn("dbo.Osobas", "KontaktTelefon_Id", c => c.Int());
            CreateIndex("dbo.Osobas", "KontaktTelefon_Id");
            AddForeignKey("dbo.Osobas", "KontaktTelefon_Id", "dbo.KontaktTelefons", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osobas", "KontaktTelefon_Id", "dbo.KontaktTelefons");
            DropIndex("dbo.Osobas", new[] { "KontaktTelefon_Id" });
            DropColumn("dbo.Osobas", "KontaktTelefon_Id");
            DropColumn("dbo.Osobas", "KontaktTelefonID");
            DropTable("dbo.KontaktTelefons");
        }
    }
}
