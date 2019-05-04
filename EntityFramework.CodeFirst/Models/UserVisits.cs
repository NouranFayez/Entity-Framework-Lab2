using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst.Models
{
   public class UserVisits
    {
        public DateTime When { get; set; }
        [Key]
        [ForeignKey("City")]
        [Column(Order =1)]
        public int fk_CityId { get; set; }
        [Key]
        [ForeignKey("User")]
        [Column(Order = 2)]
        public int fk_UserId { get; set; }
        public City City { get; set; }
        public User User { get; set; }
    }
}
