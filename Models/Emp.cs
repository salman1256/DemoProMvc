using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbEnabledApp.Models
{  [Table("Emp")]
    public class Emp
    {    [Key]
        public int MyProperty { get; set; }
        public string  Name { get; set; }
        public string  Desig { get; set; }
    }
}
