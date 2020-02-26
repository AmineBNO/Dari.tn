using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class BienImmobilier

    {

        public BienImmobilier()
        {
              
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBienImmobilier { get; set; }
        public string Status { get; set; }
        public string Localisation { get; set; }
        public string EtatBi { get; set; }

        public string ImageBi { get; set; }
        public float PrixAchat { get; set; }
        public float LoyerMensuel { get; set; }
        public float ChargeMensuel{ get; set; }
        public string  Description { get; set; }





    }
}
