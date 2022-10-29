namespace BaiKiemTra2710NND1
{
    partial class ThemNhom
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
            this.btnBoQuaN = new System.Windows.Forms.Button();
            this.btnDongYN = new System.Windows.Forms.Button();
            this.cbbTenNhom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNhomN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBoQuaN
            // 
            this.btnBoQuaN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQuaN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQuaN.Location = new System.Drawing.Point(229, 213);
            this.btnBoQuaN.Name = "btnBoQuaN";
            this.btnBoQuaN.Size = new System.Drawing.Size(75, 36);
            this.btnBoQuaN.TabIndex = 33;
            this.btnBoQuaN.Text = "Bỏ qua";
            this.btnBoQuaN.UseVisualStyleBackColor = false;
            this.btnBoQuaN.Click += new System.EventHandler(this.btnBoQuaN_Click);
            // 
            // btnDongYN
            // 
            this.btnDongYN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDongYN.Location = new System.Drawing.Point(114, 213);
            this.btnDongYN.Name = "btnDongYN";
            this.btnDongYN.Size = new System.Drawing.Size(75, 36);
            this.btnDongYN.TabIndex = 32;
            this.btnDongYN.Text = "Đồng y";
            this.btnDongYN.UseVisualStyleBackColor = false;
            this.btnDongYN.Click += new System.EventHandler(this.btnDongYN_Click);
            // 
            // cbbTenNhom
            // 
            this.cbbTenNhom.Location = new System.Drawing.Point(114, 77);
            this.cbbTenNhom.Name = "cbbTenNhom";
            this.cbbTenNhom.Size = new System.Drawing.Size(258, 20);
            this.cbbTenNhom.TabIndex = 18;
            this.cbbTenNhom.TextChanged += new System.EventHandler(this.cbbTenNhom_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ten Nhom";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbNhomN
            // 
            this.cbbNhomN.FormattingEnabled = true;
            this.cbbNhomN.Location = new System.Drawing.Point(114, 31);
            this.cbbNhomN.Name = "cbbNhomN";
            this.cbbNhomN.Size = new System.Drawing.Size(121, 21);
            this.cbbNhomN.TabIndex = 17;
            this.cbbNhomN.SelectedIndexChanged += new System.EventHandler(this.cbbNhomN_SelectedIndexChanged);
            // 
            // ThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btnBoQuaN);
            this.Controls.Add(this.btnDongYN);
            this.Controls.Add(this.cbbTenNhom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbNhomN);
            this.Name = "ThemNhom";
            this.Text = "ThemNhom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBoQuaN;
        private System.Windows.Forms.Button btnDongYN;
        private System.Windows.Forms.TextBox cbbTenNhom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNhomN;
    }
}