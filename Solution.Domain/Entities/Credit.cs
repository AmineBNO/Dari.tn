using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Credit
    {
        public Credit()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCredit { get; set; }
        public float Salaire { get; set; }
        public float SommeCredit { get; set; }
        public DateTime DateCredit { get; set; }

    }
}
