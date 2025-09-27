namespace bài_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.lstTinh = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnNguyenTo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCapNhap);
            this.groupBox1.Location = new System.Drawing.Point(43, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTinh);
            this.groupBox2.Location = new System.Drawing.Point(472, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách ước số";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(219, 56);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(118, 39);
            this.btnCapNhap.TabIndex = 0;
            this.btnCapNhap.Text = "Cập Nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(28, 62);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(140, 26);
            this.txtSo.TabIndex = 2;
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(28, 142);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(309, 28);
            this.cboSo.TabIndex = 3;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.Combobox_SelectedIndexChanged);
            // 
            // lstTinh
            // 
            this.lstTinh.FormattingEnabled = true;
            this.lstTinh.ItemHeight = 20;
            this.lstTinh.Location = new System.Drawing.Point(32, 56);
            this.lstTinh.Name = "lstTinh";
            this.lstTinh.Size = new System.Drawing.Size(249, 104);
            this.lstTinh.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(90, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(290, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(504, 293);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(234, 34);
            this.btnTong.TabIndex = 3;
            this.btnTong.Text = "Tổng các chữ số";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(504, 344);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(234, 36);
            this.btnChan.TabIndex = 4;
            this.btnChan.Text = "số lượng ước các chữ số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNguyenTo
            // 
            this.btnNguyenTo.Location = new System.Drawing.Point(504, 395);
            this.btnNguyenTo.Name = "btnNguyenTo";
            this.btnNguyenTo.Size = new System.Drawing.Size(234, 33);
            this.btnNguyenTo.TabIndex = 5;
            this.btnNguyenTo.Text = "số lượng ước các số nguyên tố";
            this.btnNguyenTo.UseVisualStyleBackColor = true;
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNguyenTo);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.ListBox lstTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnNguyenTo;
    }
}

