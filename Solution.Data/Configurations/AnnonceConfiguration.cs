using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Configurations
{
    public  class AnnonceConfiguration :EntityTypeConfiguration<Annonce>
    {

        public AnnonceConfiguration()
        {
            //one to many***
            HasOptional(prod => prod.Utilisateur).WithMany(cat => cat.Annonces)
                .HasForeignKey(prood => prood.UtilisateurId)
                .WillCascadeOnDelete(false);
            //one to many***
            //HasOptional(prod => prod.Abonnement).WithMany(cat => cat.Utilisateurs)
            //   .HasForeignKey(prood => prood.AbonnementId)
            //   .WillCascadeOnDelete(false);
        }



    }
}
