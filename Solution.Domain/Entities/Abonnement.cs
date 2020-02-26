using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
    public class Abonnement

    {
        public enum typeAbonnement
        { primum,gold}
        public Abonnement()
        {
                

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAbonnement { get; set; }
        public string Image{ get; set; }
        public typeAbonnement type { get; set; }
        public float Prix { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int? UtilisateurId { get; set; }
        //propriete de navigation
        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; }


    }
}
