namespace Vol3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresas",
                c => new
                    {
                        AdresaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.AdresaID);
            
            CreateTable(
                "dbo.KontaktTelefons",
                c => new
                    {
                        KontaktTelefonID = c.Int(nullable: false, identity: true),
                        Broj = c.Double(nullable: false),
                        Lokal = c.Int(nullable: false),
                        TipKontaktaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KontaktTelefonID)
                .ForeignKey("dbo.TipKontaktas", t => t.TipKontaktaID, cascadeDelete: true)
                .Index(t => t.TipKontaktaID);
            
            CreateTable(
                "dbo.TipKontaktas",
                c => new
                    {
                        TipKontaktaID = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.TipKontaktaID);
            
            CreateTable(
                "dbo.Mejls",
                c => new
                    {
                        MejlID = c.Int(nullable: false, identity: true),
                        MejlAdresa = c.String(),
                        TipMejlaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MejlID)
                .ForeignKey("dbo.TipMejlas", t => t.TipMejlaID, cascadeDelete: true)
                .Index(t => t.TipMejlaID);
            
            CreateTable(
                "dbo.TipMejlas",
                c => new
                    {
                        TipMejlaID = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.TipMejlaID);
            
            CreateTable(
                "dbo.Opstinas",
                c => new
                    {
                        OpstinaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        PostanskiBr = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OpstinaID);
            
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        OsobaID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        RadnoMestoID = c.Int(nullable: false),
                        KontakTelefonID = c.Int(nullable: false),
                        MejlID = c.Int(nullable: false),
                        PreduzeceID = c.Int(nullable: false),
                        KontaktTelefon_KontaktTelefonID = c.Int(),
                    })
                .PrimaryKey(t => t.OsobaID)
                .ForeignKey("dbo.KontaktTelefons", t => t.KontaktTelefon_KontaktTelefonID)
                .ForeignKey("dbo.Mejls", t => t.MejlID, cascadeDelete: true)
                .ForeignKey("dbo.Preduzeces", t => t.PreduzeceID, cascadeDelete: true)
                .ForeignKey("dbo.RadnoMestoes", t => t.RadnoMestoID, cascadeDelete: true)
                .Index(t => t.RadnoMestoID)
                .Index(t => t.MejlID)
                .Index(t => t.PreduzeceID)
                .Index(t => t.KontaktTelefon_KontaktTelefonID);
            
            CreateTable(
                "dbo.Preduzeces",
                c => new
                    {
                        PreduzeceID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        MaticniBroj = c.Double(nullable: false),
                        PIB = c.Double(nullable: false),
                        BrojRacuna = c.Double(nullable: false),
                        WebStranica = c.String(),
                        Beleska = c.String(),
                        AdresaID = c.Int(nullable: false),
                        OpstinaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PreduzeceID)
                .ForeignKey("dbo.Adresas", t => t.AdresaID, cascadeDelete: true)
                .ForeignKey("dbo.Opstinas", t => t.OpstinaID, cascadeDelete: true)
                .Index(t => t.AdresaID)
                .Index(t => t.OpstinaID);
            
            CreateTable(
                "dbo.RadnoMestoes",
                c => new
                    {
                        RadnoMestoID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.RadnoMestoID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Osobas", "RadnoMestoID", "dbo.RadnoMestoes");
            DropForeignKey("dbo.Osobas", "PreduzeceID", "dbo.Preduzeces");
            DropForeignKey("dbo.Preduzeces", "OpstinaID", "dbo.Opstinas");
            DropForeignKey("dbo.Preduzeces", "AdresaID", "dbo.Adresas");
            DropForeignKey("dbo.Osobas", "MejlID", "dbo.Mejls");
            DropForeignKey("dbo.Osobas", "KontaktTelefon_KontaktTelefonID", "dbo.KontaktTelefons");
            DropForeignKey("dbo.Mejls", "TipMejlaID", "dbo.TipMejlas");
            DropForeignKey("dbo.KontaktTelefons", "TipKontaktaID", "dbo.TipKontaktas");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Preduzeces", new[] { "OpstinaID" });
            DropIndex("dbo.Preduzeces", new[] { "AdresaID" });
            DropIndex("dbo.Osobas", new[] { "KontaktTelefon_KontaktTelefonID" });
            DropIndex("dbo.Osobas", new[] { "PreduzeceID" });
            DropIndex("dbo.Osobas", new[] { "MejlID" });
            DropIndex("dbo.Osobas", new[] { "RadnoMestoID" });
            DropIndex("dbo.Mejls", new[] { "TipMejlaID" });
            DropIndex("dbo.KontaktTelefons", new[] { "TipKontaktaID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RadnoMestoes");
            DropTable("dbo.Preduzeces");
            DropTable("dbo.Osobas");
            DropTable("dbo.Opstinas");
            DropTable("dbo.TipMejlas");
            DropTable("dbo.Mejls");
            DropTable("dbo.TipKontaktas");
            DropTable("dbo.KontaktTelefons");
            DropTable("dbo.Adresas");
        }
    }
}
