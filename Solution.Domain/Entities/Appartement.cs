using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
     public class Appartement : BienImmobilier
    {
        public Appartement()
        {

        }
        public int NombreDeChambre { get; set; }
        public int Etage { get; set; }
        public bool Ascensseur { get; set; }
        public bool CuisineEquipe { get; set; }
    }
}
