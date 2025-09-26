namespace bài_2_thực_hành
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHoTen = new TextBox();
            label1 = new Label();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            btnXOA = new Button();
            groupBox1 = new GroupBox();
            btnKQ = new Button();
            txtKQ = new TextBox();
            stop = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(319, 80);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(390, 31);
            txtHoTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 80);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập Họ Và Tên :";
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(32, 65);
            rad1.Name = "rad1";
            rad1.Size = new Size(136, 29);
            rad1.TabIndex = 2;
            rad1.TabStop = true;
            rad1.Text = "Chữ Thường";
            rad1.UseVisualStyleBackColor = true;
            rad1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(32, 141);
            rad2.Name = "rad2";
            rad2.Size = new Size(107, 29);
            rad2.TabIndex = 3;
            rad2.TabStop = true;
            rad2.Text = "Chữ Hoa";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnXOA
            // 
            btnXOA.Location = new Point(652, 168);
            btnXOA.Name = "btnXOA";
            btnXOA.Size = new Size(112, 204);
            btnXOA.TabIndex = 5;
            btnXOA.Text = "Xóa";
            btnXOA.UseVisualStyleBackColor = true;
            btnXOA.Click += btnXOA_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(39, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 204);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn Kiểu Chữ";
            // 
            // btnKQ
            // 
            btnKQ.Location = new Point(39, 388);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(112, 34);
            btnKQ.TabIndex = 7;
            btnKQ.Text = "Kết Quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(319, 390);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(390, 31);
            txtKQ.TabIndex = 8;
            // 
            // stop
            // 
            stop.Location = new Point(172, 387);
            stop.Name = "stop";
            stop.Size = new Size(112, 34);
            stop.TabIndex = 9;
            stop.Text = "dừng";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stop);
            Controls.Add(txtKQ);
            Controls.Add(btnKQ);
            Controls.Add(btnXOA);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label label1;
        private RadioButton rad1;
        private RadioButton rad2;
        private Button btnXOA;
        private GroupBox groupBox1;
        private Button btnKQ;
        private TextBox txtKQ;
        private Button stop;
    }
}
