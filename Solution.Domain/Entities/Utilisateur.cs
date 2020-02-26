using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Utilisateur
    {
        public Utilisateur()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Num { get; set; }
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        public DateTime DateDeNaissance{ get; set;}
        public long NumTel { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<Annonce> Annonces { get; set; }
        public virtual ICollection<Abonnement> Abonnements { get; set; }






    }
}
