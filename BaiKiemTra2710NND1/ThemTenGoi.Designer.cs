namespace BaiKiemTra2710NND1
{
    partial class ThemTenGoi
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
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.cbbEmail = new System.Windows.Forms.TextBox();
            this.cbbDiaChi = new System.Windows.Forms.TextBox();
            this.cbbIDNhom = new System.Windows.Forms.TextBox();
            this.cbbTenGoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNhom = new System.Windows.Forms.ComboBox();
            this.cbbSDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Location = new System.Drawing.Point(287, 357);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 36);
            this.btnBoQua.TabIndex = 51;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDongY.Location = new System.Drawing.Point(181, 357);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 36);
            this.btnDongY.TabIndex = 50;
            this.btnDongY.Text = "Đồng y";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // cbbEmail
            // 
            this.cbbEmail.Location = new System.Drawing.Point(104, 112);
            this.cbbEmail.Name = "cbbEmail";
            this.cbbEmail.Size = new System.Drawing.Size(258, 20);
            this.cbbEmail.TabIndex = 38;
            // 
            // cbbDiaChi
            // 
            this.cbbDiaChi.Location = new System.Drawing.Point(104, 164);
            this.cbbDiaChi.Name = "cbbDiaChi";
            this.cbbDiaChi.Size = new System.Drawing.Size(258, 20);
            this.cbbDiaChi.TabIndex = 39;
            // 
            // cbbIDNhom
            // 
            this.cbbIDNhom.Location = new System.Drawing.Point(104, 262);
            this.cbbIDNhom.Name = "cbbIDNhom";
            this.cbbIDNhom.Size = new System.Drawing.Size(258, 20);
            this.cbbIDNhom.TabIndex = 41;
            // 
            // cbbTenGoi
            // 
            this.cbbTenGoi.Location = new System.Drawing.Point(104, 71);
            this.cbbTenGoi.Name = "cbbTenGoi";
            this.cbbTenGoi.Size = new System.Drawing.Size(258, 20);
            this.cbbTenGoi.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID Nhom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Ten Goi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "DiaChi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nhom";
            // 
            // cbbNhom
            // 
            this.cbbNhom.FormattingEnabled = true;
            this.cbbNhom.Location = new System.Drawing.Point(104, 25);
            this.cbbNhom.Name = "cbbNhom";
            this.cbbNhom.Size = new System.Drawing.Size(121, 21);
            this.cbbNhom.TabIndex = 35;
            this.cbbNhom.SelectedIndexChanged += new System.EventHandler(this.cbbNhom_SelectedIndexChanged);
            // 
            // cbbSDT
            // 
            this.cbbSDT.Location = new System.Drawing.Point(104, 208);
            this.cbbSDT.Name = "cbbSDT";
            this.cbbSDT.Size = new System.Drawing.Size(258, 20);
            this.cbbSDT.TabIndex = 52;
            // 
            // ThemTenGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.cbbSDT);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.cbbEmail);
            this.Controls.Add(this.cbbDiaChi);
            this.Controls.Add(this.cbbIDNhom);
            this.Controls.Add(this.cbbTenGoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbNhom);
            this.Name = "ThemTenGoi";
            this.Text = "ThemTenGoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox cbbEmail;
        private System.Windows.Forms.TextBox cbbDiaChi;
        private System.Windows.Forms.TextBox cbbIDNhom;
        private System.Windows.Forms.TextBox cbbTenGoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNhom;
        private System.Windows.Forms.TextBox cbbSDT;
    }
}