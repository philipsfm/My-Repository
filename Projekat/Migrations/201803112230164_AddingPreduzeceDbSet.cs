namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPreduzeceDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Preduzeces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImePreduzeca = c.String(),
                        AdresaPreduzeca = c.String(),
                        OpstinaPreduzeca = c.String(),
                        PostanskiBrPreduzeca = c.Double(nullable: false),
                        MaticniBrPreduzeca = c.Double(nullable: false),
                        PIB = c.Double(nullable: false),
                        BrRacunaPreduzeca = c.Double(nullable: false),
                        WebStranicaPreduzeca = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Preduzeces");
        }
    }
}
