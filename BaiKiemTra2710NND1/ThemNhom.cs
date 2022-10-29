using BaiKiemTra2710NND1.service;
using BaiKiemTra2710NND1.ViewModal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTra2710NND1
{
    public partial class ThemNhom : Form
    {
        Nhom nhom;
        public ThemNhom(Nhom nhom = null)
        {
            InitializeComponent();
            NapDSTenGoi();
            this.nhom = nhom;
            if (nhom != null)
            {
                //cbb
                cbbNhomN.SelectedValue = nhom.ID;
                cbbTenNhom.Text = nhom.TenNhom;
                //cbbEmail.Text = tenGoi.Email;
               // cbbDiaChi.Text = tenGoi.DiaChi;
                //cbbSDT.Text = tenGoi.SoDienThoai;

                //cbbIDNhom.
                //cbbIDNhom.Text = tenGoi.IDNhom;
                //txtNgaySinh.Value = tenGoi.NgaySinh ?? DateTime.Now;

            }

        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return cbbNhomN.SelectedItem as NhomViewModel;
            }
        }
        void NapDSTenGoi()
        {
            var ls = NhomViewModel.GetList();
            cbbNhomN.DataSource = ls;
            cbbNhomN.ValueMember = "ID";
            cbbNhomN.DisplayMember = "TenLop";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnDongYN_Click(object sender, EventArgs e)
        {
            if (this.nhom == null)
            {
                var tg = new Nhom
                {
                    TenNhom = cbbTenNhom.Text,
                   // Email = cbbEmail.Text,
                    //DiaChi = cbbDiaChi.Text,
                    //NgaySinh = txtNgaySinh.Value,
                    //SoDienThoai = cbbSDT.Text,
                    ID = selectedNhom.ID,
                    //GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2)
                };
                if (NhomService.AddNhom(tg) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show
                        ("Ten Goi Trung", "Thong bao");
                    cbbTenNhom.Focus();
                }
            }
            else
            {
                #region cap nhat thong tin sv
                nhom.TenNhom = cbbTenNhom.Text;
               // nhom.Email = cbbEmail.Text;
                //nhom.SoDienThoai = cbbSDT.Text;
                //tenGoi.NgaySinh = txtNgaySinh.Value;
                //tenGoi.GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2);
                // tenGoi.MaSinhVien = txtMaSinhVien.Text;
                nhom.ID = selectedNhom.ID;
                //TenGoiService.UpdateTenGoi(tenGoi);
                DialogResult = DialogResult.OK;

                #endregion

            }
        }

        private void btnBoQuaN_Click(object sender, EventArgs e)
        {

        }

        private void cbbNhomN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenNhom_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
