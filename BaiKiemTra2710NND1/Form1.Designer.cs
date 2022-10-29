namespace BaiKiemTra2710NND1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThem2 = new System.Windows.Forms.ToolStripButton();
            this.btnXoa2 = new System.Windows.Forms.ToolStripButton();
            this.toolTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.qL_NhomDataSet = new BaiKiemTra2710NND1.QL_NhomDataSet();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomTableAdapter = new BaiKiemTra2710NND1.QL_NhomDataSetTableAdapters.NhomTableAdapter();
            this.qL_NhomDataSet1 = new BaiKiemTra2710NND1.QL_NhomDataSet1();
            this.tenGoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenGoiTableAdapter = new BaiKiemTra2710NND1.QL_NhomDataSet1TableAdapters.TenGoiTableAdapter();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenGoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tenGoiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(258, 32);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(530, 218);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnThem2,
            this.btnXoa2,
            this.toolTimKiem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 22);
            this.btnThem.Text = "Thêm Nhom";
            this.btnThem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 22);
            this.btnXoa.Text = "Xoa Nhom";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem2
            // 
            this.btnThem2.Image = ((System.Drawing.Image)(resources.GetObject("btnThem2.Image")));
            this.btnThem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(103, 22);
            this.btnThem2.Text = "Them Lien Lac";
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa2.Image")));
            this.btnXoa2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(93, 22);
            this.btnXoa2.Text = "Xoa Lien Lac";
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // toolTimKiem
            // 
            this.toolTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTimKiem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolTimKiem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolTimKiem.Name = "toolTimKiem";
            this.toolTimKiem.Size = new System.Drawing.Size(170, 25);
            this.toolTimKiem.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Nhập tu cần tìm";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "[Tên Gọi]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(413, 319);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(330, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(413, 392);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(330, 20);
            this.txtSdt.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(413, 357);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(413, 273);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 26);
            this.textBox1.TabIndex = 10;
            // 
            // qL_NhomDataSet
            // 
            this.qL_NhomDataSet.DataSetName = "QL_NhomDataSet";
            this.qL_NhomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataMember = "Nhom";
            this.nhomBindingSource.DataSource = this.qL_NhomDataSet;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NhomDataSet1
            // 
            this.qL_NhomDataSet1.DataSetName = "QL_NhomDataSet1";
            this.qL_NhomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenGoiBindingSource
            // 
            this.tenGoiBindingSource.DataMember = "TenGoi";
            this.tenGoiBindingSource.DataSource = this.qL_NhomDataSet1;
            // 
            // tenGoiTableAdapter
            // 
            this.tenGoiTableAdapter.ClearBeforeFill = true;
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            this.tenGoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenGoiDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - [Họ Tên Sinh Viên]";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenGoiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThem2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textBox1;
        private QL_NhomDataSet qL_NhomDataSet;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private QL_NhomDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private QL_NhomDataSet1 qL_NhomDataSet1;
        private System.Windows.Forms.BindingSource tenGoiBindingSource;
        private QL_NhomDataSet1TableAdapters.TenGoiTableAdapter tenGoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
    }
}

