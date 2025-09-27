namespace bài_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCONG = new System.Windows.Forms.RadioButton();
            this.radTRU = new System.Windows.Forms.RadioButton();
            this.radNHAN = new System.Windows.Forms.RadioButton();
            this.radCHIA = new System.Windows.Forms.RadioButton();
            this.BnKQ = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "số 2";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(310, 77);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(201, 26);
            this.txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(310, 140);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(201, 26);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCHIA);
            this.groupBox1.Controls.Add(this.radNHAN);
            this.groupBox1.Controls.Add(this.radTRU);
            this.groupBox1.Controls.Add(this.radCONG);
            this.groupBox1.Location = new System.Drawing.Point(55, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // radCONG
            // 
            this.radCONG.AutoSize = true;
            this.radCONG.Location = new System.Drawing.Point(24, 68);
            this.radCONG.Name = "radCONG";
            this.radCONG.Size = new System.Drawing.Size(69, 24);
            this.radCONG.TabIndex = 0;
            this.radCONG.TabStop = true;
            this.radCONG.Text = "cộng";
            this.radCONG.UseVisualStyleBackColor = true;
            // 
            // radTRU
            // 
            this.radTRU.AutoSize = true;
            this.radTRU.Location = new System.Drawing.Point(193, 68);
            this.radTRU.Name = "radTRU";
            this.radTRU.Size = new System.Drawing.Size(53, 24);
            this.radTRU.TabIndex = 1;
            this.radTRU.TabStop = true;
            this.radTRU.Text = "trừ";
            this.radTRU.UseVisualStyleBackColor = true;
            // 
            // radNHAN
            // 
            this.radNHAN.AutoSize = true;
            this.radNHAN.Location = new System.Drawing.Point(355, 68);
            this.radNHAN.Name = "radNHAN";
            this.radNHAN.Size = new System.Drawing.Size(70, 24);
            this.radNHAN.TabIndex = 2;
            this.radNHAN.TabStop = true;
            this.radNHAN.Text = "nhân";
            this.radNHAN.UseVisualStyleBackColor = true;
            // 
            // radCHIA
            // 
            this.radCHIA.AutoSize = true;
            this.radCHIA.Location = new System.Drawing.Point(535, 68);
            this.radCHIA.Name = "radCHIA";
            this.radCHIA.Size = new System.Drawing.Size(63, 24);
            this.radCHIA.TabIndex = 3;
            this.radCHIA.TabStop = true;
            this.radCHIA.Text = "chia";
            this.radCHIA.UseVisualStyleBackColor = true;
            // 
            // BnKQ
            // 
            this.BnKQ.Location = new System.Drawing.Point(65, 376);
            this.BnKQ.Name = "BnKQ";
            this.BnKQ.Size = new System.Drawing.Size(109, 43);
            this.BnKQ.TabIndex = 5;
            this.BnKQ.Text = "kết quả";
            this.BnKQ.UseVisualStyleBackColor = true;
            this.BnKQ.Click += new System.EventHandler(this.BnKQ_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(310, 384);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(270, 26);
            this.txtKQ.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.BnKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCHIA;
        private System.Windows.Forms.RadioButton radNHAN;
        private System.Windows.Forms.RadioButton radTRU;
        private System.Windows.Forms.RadioButton radCONG;
        private System.Windows.Forms.Button BnKQ;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

