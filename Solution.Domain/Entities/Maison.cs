using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Maison:BienImmobilier
    {
        public Maison()
        {

        }
        public int NombreDeChambre { get; set; }
        public bool jardin { get; set; }

    }
}
