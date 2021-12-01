namespace QLHD.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDongBHXH")]
    public partial class ChiTietDongBHXH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string maBHXH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string maLanDong { get; set; }

        [StringLength(2)]
        public string thang { get; set; }

        [StringLength(4)]
        public string nam { get; set; }

        public DateTime? ngayDong { get; set; }

        public double? soTien { get; set; }

        public virtual SoBHXH SoBHXH { get; set; }
    }
}
