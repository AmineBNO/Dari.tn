using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SolutionPI.Web.Models
{
    public class AbonnementModels
    {
        public enum typeAbonnementModel { primum, gold }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAbonnementM { get; set; }
        public string ImageAbonnementM { get; set; }
        public typeAbonnementModel typeM { get; set; }
        public float PrixAbonnementM { get; set; }
        public DateTime DateDebutAbonnementM{ get; set; }
        public DateTime DateFinAbonnementM { get; set; }

        public int? UtilisateurId { get; set; }
        //propriete de navigation
        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; }

        public AbonnementModels() { }

    }
}