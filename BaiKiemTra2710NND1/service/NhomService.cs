using BaiKiemTra2710NND1.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra2710NND1.service
{
    internal class NhomService
    {
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                //TenGoi1 = e.TenGoi1,
                //Email = e.Email,
                //DiaChi = e.DiaChi,
                //SoDienThoai = e.SoDienThoai,
                TenNhom = e.TenNhom
            }).ToList();
            return rs;
        }
        public static List<NhomViewModel> getByNhom(int ID)
        {
            var list = GetList();
            var rs = list.Where(t => t.ID == ID).ToList();
            return rs;
        }
        public static KetQua AddNhom(Nhom tg)
        {
            var db = new AppDBContext();
            int count = db.Nhoms.Where(e => e.TenNhom == tg.TenNhom).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.Nhoms.Add(tg);
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
        public static KetQua RemoveNhom(NhomViewModel tg)
        {
            var db = new AppDBContext();
            var nHom = db.Nhoms.Where(e => e.ID == tg.ID).FirstOrDefault();
            db.Nhoms.Remove(nHom);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
