namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abonnements", "UtilisateurId", c => c.Int());
            CreateIndex("dbo.Abonnements", "UtilisateurId");
            AddForeignKey("dbo.Abonnements", "UtilisateurId", "dbo.Utilisateurs", "Num");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abonnements", "UtilisateurId", "dbo.Utilisateurs");
            DropIndex("dbo.Abonnements", new[] { "UtilisateurId" });
            DropColumn("dbo.Abonnements", "UtilisateurId");
        }
    }
}
