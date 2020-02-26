using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=machaine")
        {

        }
        //les dbsets
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Abonnement> abonnements  { get; set; }
        public DbSet<Annonce>annonces  { get; set; }
        public DbSet<Appartement> appartements  { get; set; }
        public DbSet<BienImmobilier>  bienImmobiliers  { get; set; }
        public DbSet<Contrat>contrats  { get; set; }
        public DbSet<Credit> credits  { get; set; }
        public DbSet<Maison> maisons  { get; set; }
        public DbSet<Meuble>meubles  { get; set; }
        public DbSet<Notification>  notifications { get; set; }
        public DbSet<Panier>paniers  { get; set; }
        public DbSet<Studio>studios  { get; set; }
        public DbSet<Terrain>terrains  { get; set; }
        public DbSet<Visite> visites  { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //config + conventions
            //modelBuilder.Configurations.Add(...);
            //modelBuilder.Conventions.Add(...);
        }
    }
}
