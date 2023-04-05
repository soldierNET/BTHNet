namespace BaiThucHanh11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSNV")]
    public partial class DSNV
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(50)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChucVu { get; set; }

        public double? HeSoLuong { get; set; }
    }
}
