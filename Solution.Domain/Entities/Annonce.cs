using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Annonce
    {
        public enum Statut { disponible, non_Disponible }
        public enum Type
        {Location,Vente }
        public Annonce()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAnnonce { get; set; }
        public DateTime DateAnnonce { get; set; }
        public string Titre { get; set; }
        public Type type { get; set; }
        public Statut statut { get; set; }

        public int? UtilisateurId { get; set; }
        //propriete de navigation
        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; }





    }
}
