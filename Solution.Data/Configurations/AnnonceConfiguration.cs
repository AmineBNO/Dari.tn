using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities;
using Solution.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Configurations
{
    public class AnnonceConfiguration : EntityTypeConfiguration<Annonce>
    {

        public AnnonceConfiguration()
        {
            //one to many***
            HasOptional(prod => prod.Utilisateur).WithMany(cat => cat.Annonces)
                .HasForeignKey(prood => prood.UtilisateurId)
                .WillCascadeOnDelete(false);

            // Many to Many
                this.HasMany<Utilisateur>(r => r.Utilisateurs)
                    .WithMany(r => r.AnnoncesContrat)
                    .Map(c =>
                    {
                        c.MapLeftKey("Utilisateurs");
                        c.MapRightKey("Annonces");
                        c.ToTable("UserAnnonceContrat");
                    });
        }
    }
}
