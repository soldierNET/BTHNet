namespace BaiThucHanh11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMPHONG")]
    public partial class DMPHONG
    {
        [Key]
        [StringLength(50)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }
    }
}
