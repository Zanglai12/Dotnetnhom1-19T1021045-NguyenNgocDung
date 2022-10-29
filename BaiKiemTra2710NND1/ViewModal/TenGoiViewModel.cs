using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra2710NND1.ViewModal
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong
    }
        public class TenGoiViewModel
        {
            public int ID { get; set; }

            public string TenGoi1 { get; set; }

            public string Email { get; set; }

            public string DiaChi { get; set; }

            public string SoDienThoai { get; set; }

            public int? IDNhom { get; set; }

   // public virtual Nhom Nhom { get; set; }
    }
}
