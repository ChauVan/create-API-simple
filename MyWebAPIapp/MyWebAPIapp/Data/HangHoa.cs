using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebAPIapp.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHh { get; set; }
        [Required]
        public string TenHh { get; set; }
        public string MoTa { get; set; }
        public double DonGia { get; set; }
        [Range(0, double.MaxValue)]
        public byte GiamGia { get; set; }

    }
}
