using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
    public class Notification
    {
        public Notification()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotification { get; set; }
        public string Nom { get; set; }
        public DateTime DateNotif { get; set; }
        public string Description{ get; set; }

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
