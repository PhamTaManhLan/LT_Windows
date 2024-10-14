namespace Tuan7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [Key]
        [StringLength(5)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        public DateTime? Ngaynhap { get; set; }

        [StringLength(2)]
        public string MaLoaiSP { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
    }
}
