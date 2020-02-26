using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Studio:BienImmobilier
    {
        public enum TypeStudio { meublée,non_meublée}
        public Studio()
        {

        }
        public int Etage { get; set; }
        public TypeStudio type { get; set; }
    }
}
