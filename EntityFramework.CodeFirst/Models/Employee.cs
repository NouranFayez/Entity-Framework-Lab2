using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int fk_DeptId { get; set; }

        public Department Department { get; set; }
        public List<Book> Books { get; set; }

    }
}
