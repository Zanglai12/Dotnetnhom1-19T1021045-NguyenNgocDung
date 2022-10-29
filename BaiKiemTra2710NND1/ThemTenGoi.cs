using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiKiemTra2710NND1.service;
using BaiKiemTra2710NND1.ViewModal;

namespace BaiKiemTra2710NND1
{
    public partial class ThemTenGoi : Form
    {
        TenGoi tenGoi;
        public ThemTenGoi(TenGoi tenGoi = null)
        {
            InitializeComponent();
            NapDSNhom();
            this.tenGoi = tenGoi;
            if (tenGoi != null)
            {
                //cbb
                cbbNhom.SelectedValue = tenGoi.Nhom;
                cbbTenGoi.Text = tenGoi.TenGoi1;
                cbbEmail.Text = tenGoi.Email;
                cbbDiaChi.Text = tenGoi.DiaChi;
                cbbSDT.Text = tenGoi.SoDienThoai;

                //cbbIDNhom.
                //cbbIDNhom.Text = tenGoi.IDNhom;
                //txtNgaySinh.Value = tenGoi.NgaySinh ?? DateTime.Now;

            }
            //cbbIDNhom. = tenGoi.IDNhom;

        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return cbbNhom.SelectedItem as NhomViewModel;
            }
        }
        void NapDSNhom()
        {
            var ls = NhomViewModel.GetList();
            cbbNhom.DataSource = ls;
            cbbNhom.ValueMember = "ID";
            cbbNhom.DisplayMember = "TenLop";
        }

        private void cbbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.tenGoi == null)
            {
                var tg = new TenGoi
                {
                    TenGoi1 = cbbTenGoi.Text,
                    Email = cbbEmail.Text,
                    DiaChi = cbbDiaChi.Text,
                    //NgaySinh = txtNgaySinh.Value,
                    SoDienThoai = cbbSDT.Text,
                    IDNhom = selectedNhom.ID,
                    //GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2)
                };
                if (TenGoiService.AddTenGoi(tg) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show
                        ("Ten Goi Trung", "Thong bao");
                    cbbTenGoi.Focus();
                }
            }
            else
            {
                #region cap nhat thong tin sv
                tenGoi.TenGoi1 = cbbTenGoi.Text;
                tenGoi.Email = cbbEmail.Text;
                tenGoi.SoDienThoai = cbbSDT.Text;
                //tenGoi.NgaySinh = txtNgaySinh.Value;
                //tenGoi.GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2);
               // tenGoi.MaSinhVien = txtMaSinhVien.Text;
                tenGoi.IDNhom = selectedNhom.ID;
                //TenGoiService.UpdateTenGoi(tenGoi);
                DialogResult = DialogResult.OK;

                #endregion

            }
        }
    }
}
