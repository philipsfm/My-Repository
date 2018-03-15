namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PotvrdiAnotacijeNaImenuOsobe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osobas", "Ime", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "Ime", c => c.String());
        }
    }
}
