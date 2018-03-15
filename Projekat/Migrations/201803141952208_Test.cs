namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Osobas", "TipMejlAdrese", c => c.String());
            AddColumn("dbo.Osobas", "MejlAdresa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Osobas", "MejlAdresa");
            DropColumn("dbo.Osobas", "TipMejlAdrese");
        }
    }
}
