namespace Vol3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajTipTel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into TipKontaktas ( Opis) values('Kancelarija')");
            Sql("Insert into TipKontaktas ( Opis) values('Sluzbeni Mobilni')");
            Sql("Insert into TipKontaktas ( Opis) values('Privatni Mobilni')");
        }
        
        public override void Down()
        {
        }
    }
}
