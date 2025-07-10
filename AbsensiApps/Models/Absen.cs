using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbsensiApps.Models
{
    [Table("Absen")] 
    public class Absen
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Employee")]
        public string NIK { get; set; } = string.Empty;
        public DateTime TanggalAbsen { get; set; }

        public Employee? Employee { get; set; }
    }
}
