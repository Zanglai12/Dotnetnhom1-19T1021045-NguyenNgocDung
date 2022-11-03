using kiemtra.Model;
using kiemtra.services;
using kiemtra.ViewModel;
using System;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class frmNhom : Form
    {
        NhomViewModel nhom = null;
        public frmNhom()
        {
            InitializeComponent();
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (this.nhom == null)
            {
                var n = new Nhom
                {
                    TenNhom = txtTenNhom.Text
                };
                if (Nhomservices.AddNhom(n) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Tên nhóm trùng", "Thông báo");
                    txtTenNhom.Focus();
                }
            }
        }
    }
}

