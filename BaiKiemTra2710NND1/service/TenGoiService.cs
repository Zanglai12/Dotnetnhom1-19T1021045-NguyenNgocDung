using BaiKiemTra2710NND1.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra2710NND1.service
{
    internal class TenGoiService
    {
        public static List<TenGoiViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.TenGois.Select(e => new TenGoiViewModel
            {
                ID = e.ID,
                TenGoi1 = e.TenGoi1,
                Email = e.Email,
                DiaChi = e.DiaChi,
                SoDienThoai = e.SoDienThoai,
                IDNhom = e.IDNhom
            }).ToList();
            return rs;
        }
        public static List<TenGoiViewModel> getByNhom(int IDNhom)
        {
            var list = GetList();
            var rs = list.Where(t => t.IDNhom == IDNhom).ToList();
            return rs;
        }
        public static KetQua AddTenGoi(TenGoi tg)
        {
            var db = new AppDBContext();
            int count = db.TenGois.Where(e => e.TenGoi1 == tg.TenGoi1).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.TenGois.Add(tg);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
            // db.SinhViens.Add(sv);
            // db.SaveChanges();
        }
        //public static KetQua UpdateSinhVien(TenGoiViewModel tg)
        //{
         //   var db = new AppDBContext();
           // var tenGoi = db.TenGois.Where(e => e.ID == tg.ID).FirstOrDefault();
    //        tenGoi.TenGoi1 = tg.TenGoi1;
      //      tenGoi.Email = tg.Email;
        //    tenGoi.DiaChi = tg.QueQuan;
          //  tenGoi.IDLopHoc = tg.IDLopHoc;
//            tenGoi.GioiTinh = tg.GioiTinh;
  //          tenGoi.MaSinhVien = tg.MaSinhVien;
    //        tenGoi.NgaySinh = tg.NgaySinh;
      //      db.SaveChanges();
        //    return KetQua.ThanhCong;
      //  }
        public static KetQua RemoveTenGoi(TenGoiViewModel tg)
        {
            var db = new AppDBContext();
            var tenGoi = db.TenGois.Where(e => e.ID == tg.ID).FirstOrDefault();
            db.TenGois.Remove(tenGoi);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
