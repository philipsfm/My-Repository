namespace Vol3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajTipMejla : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into TipMejlas ( Opis) values('Poslovni')");
            Sql("Insert into TipMejlas ( Opis) values('Privatni')");
        }
        
        public override void Down()
        {
        }
    }
}
