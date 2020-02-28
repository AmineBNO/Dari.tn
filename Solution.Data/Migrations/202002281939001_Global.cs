namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Global : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonnements",
                c => new
                    {
                        IdAbonnement = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        type = c.Int(nullable: false),
                        Prix = c.Single(nullable: false),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        UtilisateurId = c.Int(),
                    })
                .PrimaryKey(t => t.IdAbonnement)
                .ForeignKey("dbo.Utilisateurs", t => t.UtilisateurId)
                .Index(t => t.UtilisateurId);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Num = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(nullable: false),
                        DateDeNaissance = c.DateTime(nullable: false),
                        NumTel = c.Long(nullable: false),
                        Password = c.String(nullable: false),
                        Notification_IdNotification = c.Int(),
                    })
                .PrimaryKey(t => t.Num)
                .ForeignKey("dbo.Notifications", t => t.Notification_IdNotification)
                .Index(t => t.Notification_IdNotification);
            
            CreateTable(
                "dbo.Annonces",
                c => new
                    {
                        IdAnnonce = c.Int(nullable: false, identity: true),
                        DateAnnonce = c.DateTime(nullable: false),
                        Titre = c.String(),
                        type = c.Int(nullable: false),
                        statut = c.Int(nullable: false),
                        UtilisateurId = c.Int(),
                    })
                .PrimaryKey(t => t.IdAnnonce)
                .ForeignKey("dbo.Utilisateurs", t => t.UtilisateurId)
                .Index(t => t.UtilisateurId);
            
            CreateTable(
                "dbo.BienImmobiliers",
                c => new
                    {
                        IdBienImmobilier = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Localisation = c.String(),
                        EtatBi = c.String(),
                        ImageBi = c.String(),
                        PrixAchat = c.Single(nullable: false),
                        LoyerMensuel = c.Single(nullable: false),
                        ChargeMensuel = c.Single(nullable: false),
                        Description = c.String(),
                        NombreDeChambre = c.Int(),
                        Etage = c.Int(),
                        Ascensseur = c.Boolean(),
                        CuisineEquipe = c.Boolean(),
                        NombreDeChambre1 = c.Int(),
                        jardin = c.Boolean(),
                        Etage1 = c.Int(),
                        type = c.Int(),
                        Superficie = c.Single(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.IdBienImmobilier);
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        ClientID = c.Int(nullable: false),
                        AnnonceId = c.Int(nullable: false),
                        DateContrat = c.DateTime(nullable: false),
                        DateFinContrat = c.DateTime(nullable: false),
                        Description = c.String(),
                        PrixContrat = c.Single(nullable: false),
                        motif = c.Int(nullable: false),
                        Annonce_IdAnnonce = c.Int(),
                        Client_Num = c.Int(),
                    })
                .PrimaryKey(t => new { t.ClientID, t.AnnonceId })
                .ForeignKey("dbo.Annonces", t => t.Annonce_IdAnnonce)
                .ForeignKey("dbo.Utilisateurs", t => t.Client_Num)
                .Index(t => t.Annonce_IdAnnonce)
                .Index(t => t.Client_Num);
            
            CreateTable(
                "dbo.Credits",
                c => new
                    {
                        IdCredit = c.Int(nullable: false, identity: true),
                        Salaire = c.Single(nullable: false),
                        SommeCredit = c.Single(nullable: false),
                        DateCredit = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCredit);
            
            CreateTable(
                "dbo.Meubles",
                c => new
                    {
                        IdMeuble = c.Int(nullable: false, identity: true),
                        Localistion = c.String(),
                        Image = c.String(),
                        PrixM = c.Single(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IdMeuble);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        IdNotification = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        DateNotif = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IdNotification);
            
            CreateTable(
                "dbo.Paniers",
                c => new
                    {
                        IdPanier = c.Int(nullable: false, identity: true),
                        typeDePayment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPanier);
            
            CreateTable(
                "dbo.Visites",
                c => new
                    {
                        IdVisite = c.Int(nullable: false, identity: true),
                        DateVisite = c.DateTime(nullable: false),
                        Etat = c.String(),
                    })
                .PrimaryKey(t => t.IdVisite);
            
            CreateTable(
                "dbo.UserAnnonceContrat",
                c => new
                    {
                        Utilisateurs = c.Int(nullable: false),
                        Annonces = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilisateurs, t.Annonces })
                .ForeignKey("dbo.Annonces", t => t.Utilisateurs, cascadeDelete: true)
                .ForeignKey("dbo.Utilisateurs", t => t.Annonces, cascadeDelete: true)
                .Index(t => t.Utilisateurs)
                .Index(t => t.Annonces);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilisateurs", "Notification_IdNotification", "dbo.Notifications");
            DropForeignKey("dbo.Contrats", "Client_Num", "dbo.Utilisateurs");
            DropForeignKey("dbo.Contrats", "Annonce_IdAnnonce", "dbo.Annonces");
            DropForeignKey("dbo.UserAnnonceContrat", "Annonces", "dbo.Utilisateurs");
            DropForeignKey("dbo.UserAnnonceContrat", "Utilisateurs", "dbo.Annonces");
            DropForeignKey("dbo.Annonces", "UtilisateurId", "dbo.Utilisateurs");
            DropForeignKey("dbo.Abonnements", "UtilisateurId", "dbo.Utilisateurs");
            DropIndex("dbo.UserAnnonceContrat", new[] { "Annonces" });
            DropIndex("dbo.UserAnnonceContrat", new[] { "Utilisateurs" });
            DropIndex("dbo.Contrats", new[] { "Client_Num" });
            DropIndex("dbo.Contrats", new[] { "Annonce_IdAnnonce" });
            DropIndex("dbo.Annonces", new[] { "UtilisateurId" });
            DropIndex("dbo.Utilisateurs", new[] { "Notification_IdNotification" });
            DropIndex("dbo.Abonnements", new[] { "UtilisateurId" });
            DropTable("dbo.UserAnnonceContrat");
            DropTable("dbo.Visites");
            DropTable("dbo.Paniers");
            DropTable("dbo.Notifications");
            DropTable("dbo.Meubles");
            DropTable("dbo.Credits");
            DropTable("dbo.Contrats");
            DropTable("dbo.BienImmobiliers");
            DropTable("dbo.Annonces");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Abonnements");
        }
    }
}
