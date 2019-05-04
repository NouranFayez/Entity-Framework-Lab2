using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst.Models
{
    [Table("City")]
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        [ForeignKey("Country")]
        public int fk_CountryId { get; set; }
        public List<UserVisits> UserVisits { get; set; }
        public Book Book { get; set; }


    }
}
