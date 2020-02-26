using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Contrat

    {
        public enum Motif
        { Location, Vente }
        public Contrat()
        {

        }
   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdContrat { get; set; }
        public DateTime DateContrat { get; set; }
        public DateTime DateFinContrat { get; set; }
        public string Description { get; set; }
        public float PrixContrat { get; set; }
        public Motif  motif { get; set; }

    }
}
