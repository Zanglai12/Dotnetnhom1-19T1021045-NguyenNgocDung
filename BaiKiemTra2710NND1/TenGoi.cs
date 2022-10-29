namespace BaiKiemTra2710NND1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenGoi")]
    public partial class TenGoi
    {

        public int ID { get; set; }

        //[Column("TenGoi")]
        [StringLength(50)]
        public string TenGoi1 { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public int? IDNhom { get; set; }

        public virtual Nhom Nhom { get; set; }
    }
}
