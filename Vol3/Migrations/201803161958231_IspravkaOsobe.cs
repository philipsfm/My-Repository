namespace Vol3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IspravkaOsobe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Osobas", "KontaktTelefon_KontaktTelefonID", "dbo.KontaktTelefons");
            DropIndex("dbo.Osobas", new[] { "KontaktTelefon_KontaktTelefonID" });
            RenameColumn(table: "dbo.Osobas", name: "KontaktTelefon_KontaktTelefonID", newName: "KontaktTelefonID");
            AlterColumn("dbo.Osobas", "KontaktTelefonID", c => c.Int(nullable: false));
            CreateIndex("dbo.Osobas", "KontaktTelefonID");
            AddForeignKey("dbo.Osobas", "KontaktTelefonID", "dbo.KontaktTelefons", "KontaktTelefonID", cascadeDelete: true);
            DropColumn("dbo.Osobas", "KontakTelefonID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Osobas", "KontakTelefonID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Osobas", "KontaktTelefonID", "dbo.KontaktTelefons");
            DropIndex("dbo.Osobas", new[] { "KontaktTelefonID" });
            AlterColumn("dbo.Osobas", "KontaktTelefonID", c => c.Int());
            RenameColumn(table: "dbo.Osobas", name: "KontaktTelefonID", newName: "KontaktTelefon_KontaktTelefonID");
            CreateIndex("dbo.Osobas", "KontaktTelefon_KontaktTelefonID");
            AddForeignKey("dbo.Osobas", "KontaktTelefon_KontaktTelefonID", "dbo.KontaktTelefons", "KontaktTelefonID");
        }
    }
}
