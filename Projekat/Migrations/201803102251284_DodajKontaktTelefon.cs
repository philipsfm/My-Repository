namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajKontaktTelefon : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into KontaktTelefons ( TipKontaktTelefona, BrKontaktTelefona,Lokal) values('Kucni',0112671746,0)");
            Sql("Insert into KontaktTelefons (TipKontaktTelefona, BrKontaktTelefona,Lokal) values('Mobilni',011211111,1)");
            Sql("Insert into KontaktTelefons ( TipKontaktTelefona, BrKontaktTelefona,Lokal) values('Faks',064512181,2)");
            Sql("Insert into KontaktTelefons ( TipKontaktTelefona, BrKontaktTelefona,Lokal) values('Mobilni',0643939721,3)");
        }
        
        public override void Down()
        {
        }
    }
}
