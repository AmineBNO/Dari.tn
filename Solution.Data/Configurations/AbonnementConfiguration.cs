using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Configurations
{
    class AbonnementConfiguration : EntityTypeConfiguration<Abonnement>
    {
        public AbonnementConfiguration()
        {
            //one to many***
            HasOptional(prod => prod.Utilisateur).WithMany(cat => cat.Abonnements)
                .HasForeignKey(prood => prood.UtilisateurId)
                .WillCascadeOnDelete(false);



        }
    }
}
