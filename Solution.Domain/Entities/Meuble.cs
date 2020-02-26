using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Meuble
    {
       
        public Meuble()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMeuble { get; set; }
        public string  Localistion { get; set; }
       
        public string Image { get; set; }
        public float PrixM { get; set; }
        public string Description { get; set; }

    }
}
