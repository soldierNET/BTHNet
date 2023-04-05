namespace BaiThucHanh11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVU")]
    public partial class CHUCVU
    {
        [Key]
        [StringLength(50)]
        public string MaChucVu { get; set; }

        [StringLength(50)]
        public string TenChucVu { get; set; }

        public double? PhuCap { get; set; }
    }
}
