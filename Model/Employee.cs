using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagement.Model
{
    [Table("Users")]
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string role { get; set; }

        public string email { get; set; }
        public string salary { get; set; }
        public string status { get; set; }
    }
}
