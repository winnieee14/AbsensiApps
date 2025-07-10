using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbsensiApps.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string NIK { get; set; } = string.Empty;

        public string Nama { get; set; } = string.Empty;
    }
}
