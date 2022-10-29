using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra2710NND1.ViewModal
{
    public class NhomViewModel
    {
        public int ID { get; set; }
        public string TenNhom { get; set; }
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom
            }).ToList();
            return rs;
        }
    }
}
