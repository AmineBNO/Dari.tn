using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SolutionPI.Web.Models
{
    public class ContratModel
    {
        public ContratModel() { }
        public enum Motif { Location, Vente }

        [Key, Column(Order = 1)]
        public int ClientID { get; set; }
        public Utilisateur Client { get; set; }

        [Key, Column(Order = 2)]
        public int AnnonceId { get; set; }
        public Annonce Annonce { get; set; }

        public DateTime DateContrat { get; set; }
        public DateTime DateFinContrat { get; set; }
        public string Description { get; set; }
        public float PrixContrat { get; set; }
        public Motif motif { get; set; }

    }
}