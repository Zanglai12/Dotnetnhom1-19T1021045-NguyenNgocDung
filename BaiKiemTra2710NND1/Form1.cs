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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSNhom();
            NapDSTenGoi();
        }
        void NapDSNhom()
        {
            var ls = NhomViewModel.GetList();
            //cbbN.DataSource = ls;
            //cbbNhom.DisplayMember = "TenLop";
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomBindingSource.DataSource as NhomViewModel;
            }
        }
        public TenGoiViewModel SelectedTenGoi
        {
            get
            {
                return nhomBindingSource.Current as TenGoiViewModel;
                //return DataGridView.SelectedRows
            }
        }
        void NapDSTenGoi()
        {
            if (selectedNhom != null)
            {
                var list = TenGoiService.getByNhom(selectedNhom.ID);
                //sinhVienViewModelBindingSource.DataSource = list;
                //bdsSinhVien.DataSource = list;
                //dataGridView2.DataSource = list;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NhomDataSet1.TenGoi' table. You can move, or remove it, as needed.
            this.tenGoiTableAdapter.Fill(this.qL_NhomDataSet1.TenGoi);
            // TODO: This line of code loads data into the 'qL_NhomDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Fill(this.qL_NhomDataSet.Nhom);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //
            var f = new ThemNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSNhom();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
       // private void btnThem_Click(object sender, EventArgs e)
       // {
          
      //  }

        private void btnThem2_Click(object sender, EventArgs e)
        {
             var f = new ThemTenGoi();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSTenGoi();
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            if (SelectedTenGoi != null)
            {
                var rs = MessageBox.Show("Ban co chac la muon xoa?", "chu y", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    TenGoiService.RemoveTenGoi(SelectedTenGoi);
                    NapDSTenGoi();
                }
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Ban co chac la muon xoa?", "chu y", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomService.RemoveNhom(selectedNhom);
                    NapDSNhom();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
