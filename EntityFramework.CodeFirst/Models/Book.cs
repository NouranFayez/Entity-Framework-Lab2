using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }
        public City City { get; set; }
        public Cover Cover { get; set; }
    }
}
