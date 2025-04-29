namespace DoanC_
{
    partial class frmChon_Phuong_Thuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChon_Phuong_Thuc));
            this.pnlvien = new System.Windows.Forms.Panel();
            this.lblchonpt = new System.Windows.Forms.Label();
            this.piclogoueh = new System.Windows.Forms.PictureBox();
            this.pnlkhung = new System.Windows.Forms.Panel();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnPT5 = new System.Windows.Forms.Button();
            this.btnPT4ASEAN_ISB = new System.Windows.Forms.Button();
            this.btnPT4KSA_KSV = new System.Windows.Forms.Button();
            this.btnPT3ASEAN_ISB = new System.Windows.Forms.Button();
            this.btnPT3KSA_KSV = new System.Windows.Forms.Button();
            this.picsv = new System.Windows.Forms.PictureBox();
            this.pnlvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoueh)).BeginInit();
            this.pnlkhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlvien
            // 
            this.pnlvien.BackColor = System.Drawing.Color.Teal;
            this.pnlvien.Controls.Add(this.lblchonpt);
            this.pnlvien.Controls.Add(this.piclogoueh);
            this.pnlvien.Location = new System.Drawing.Point(0, 0);
            this.pnlvien.Margin = new System.Windows.Forms.Padding(2);
            this.pnlvien.Name = "pnlvien";
            this.pnlvien.Size = new System.Drawing.Size(1153, 130);
            this.pnlvien.TabIndex = 101;
            // 
            // lblchonpt
            // 
            this.lblchonpt.BackColor = System.Drawing.Color.Teal;
            this.lblchonpt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblchonpt.ForeColor = System.Drawing.Color.White;
            this.lblchonpt.Location = new System.Drawing.Point(285, 39);
            this.lblchonpt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblchonpt.Name = "lblchonpt";
            this.lblchonpt.Size = new System.Drawing.Size(707, 50);
            this.lblchonpt.TabIndex = 0;
            this.lblchonpt.Text = "CHỌN PHƯƠNG THỨC XÉT TUYỂN";
            this.lblchonpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piclogoueh
            // 
            this.piclogoueh.BackColor = System.Drawing.Color.White;
            this.piclogoueh.Image = ((System.Drawing.Image)(resources.GetObject("piclogoueh.Image")));
            this.piclogoueh.Location = new System.Drawing.Point(29, 20);
            this.piclogoueh.Margin = new System.Windows.Forms.Padding(2);
            this.piclogoueh.Name = "piclogoueh";
            this.piclogoueh.Size = new System.Drawing.Size(143, 93);
            this.piclogoueh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogoueh.TabIndex = 2;
            this.piclogoueh.TabStop = false;
            // 
            // pnlkhung
            // 
            this.pnlkhung.BackColor = System.Drawing.Color.MintCream;
            this.pnlkhung.Controls.Add(this.btnTV);
            this.pnlkhung.Controls.Add(this.btnPT5);
            this.pnlkhung.Controls.Add(this.btnPT4ASEAN_ISB);
            this.pnlkhung.Controls.Add(this.btnPT4KSA_KSV);
            this.pnlkhung.Controls.Add(this.btnPT3ASEAN_ISB);
            this.pnlkhung.Controls.Add(this.btnPT3KSA_KSV);
            this.pnlkhung.Location = new System.Drawing.Point(571, 117);
            this.pnlkhung.Margin = new System.Windows.Forms.Padding(2);
            this.pnlkhung.Name = "pnlkhung";
            this.pnlkhung.Size = new System.Drawing.Size(562, 660);
            this.pnlkhung.TabIndex = 103;
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.Teal;
            this.btnTV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTV.ForeColor = System.Drawing.Color.White;
            this.btnTV.Location = new System.Drawing.Point(150, 550);
            this.btnTV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(265, 51);
            this.btnTV.TabIndex = 104;
            this.btnTV.Text = "Trở về trang chủ";
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnPT5
            // 
            this.btnPT5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPT5.ForeColor = System.Drawing.Color.Teal;
            this.btnPT5.Location = new System.Drawing.Point(54, 449);
            this.btnPT5.Margin = new System.Windows.Forms.Padding(2);
            this.btnPT5.Name = "btnPT5";
            this.btnPT5.Size = new System.Drawing.Size(456, 48);
            this.btnPT5.TabIndex = 4;
            this.btnPT5.Text = "    PHƯƠNG THỨC 5 (DGNL)";
            this.btnPT5.UseVisualStyleBackColor = true;
            this.btnPT5.Click += new System.EventHandler(this.btnPT5_Click);
            // 
            // btnPT4ASEAN_ISB
            // 
            this.btnPT4ASEAN_ISB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPT4ASEAN_ISB.ForeColor = System.Drawing.Color.Teal;
            this.btnPT4ASEAN_ISB.Location = new System.Drawing.Point(54, 356);
            this.btnPT4ASEAN_ISB.Margin = new System.Windows.Forms.Padding(2);
            this.btnPT4ASEAN_ISB.Name = "btnPT4ASEAN_ISB";
            this.btnPT4ASEAN_ISB.Size = new System.Drawing.Size(456, 48);
            this.btnPT4ASEAN_ISB.TabIndex = 3;
            this.btnPT4ASEAN_ISB.Text = "    PHƯƠNG THỨC 4 (ASEAN VÀ ISB)";
            this.btnPT4ASEAN_ISB.UseVisualStyleBackColor = true;
            this.btnPT4ASEAN_ISB.Click += new System.EventHandler(this.btnPT4ASEAN_ISB_Click);
            // 
            // btnPT4KSA_KSV
            // 
            this.btnPT4KSA_KSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPT4KSA_KSV.ForeColor = System.Drawing.Color.Teal;
            this.btnPT4KSA_KSV.Location = new System.Drawing.Point(54, 263);
            this.btnPT4KSA_KSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnPT4KSA_KSV.Name = "btnPT4KSA_KSV";
            this.btnPT4KSA_KSV.Size = new System.Drawing.Size(456, 48);
            this.btnPT4KSA_KSV.TabIndex = 2;
            this.btnPT4KSA_KSV.Text = "    PHƯƠNG THỨC 4 (KSA VÀ KSV)";
            this.btnPT4KSA_KSV.UseVisualStyleBackColor = true;
            this.btnPT4KSA_KSV.Click += new System.EventHandler(this.btnPT4KSA_KSV_Click);
            // 
            // btnPT3ASEAN_ISB
            // 
            this.btnPT3ASEAN_ISB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPT3ASEAN_ISB.ForeColor = System.Drawing.Color.Teal;
            this.btnPT3ASEAN_ISB.Location = new System.Drawing.Point(54, 170);
            this.btnPT3ASEAN_ISB.Margin = new System.Windows.Forms.Padding(2);
            this.btnPT3ASEAN_ISB.Name = "btnPT3ASEAN_ISB";
            this.btnPT3ASEAN_ISB.Size = new System.Drawing.Size(456, 48);
            this.btnPT3ASEAN_ISB.TabIndex = 1;
            this.btnPT3ASEAN_ISB.Text = "    PHƯƠNG THỨC 3 (ASEAN VÀ ISB)";
            this.btnPT3ASEAN_ISB.UseVisualStyleBackColor = true;
            this.btnPT3ASEAN_ISB.Click += new System.EventHandler(this.btnPT3ASEAN_ISB_Click);
            // 
            // btnPT3KSA_KSV
            // 
            this.btnPT3KSA_KSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPT3KSA_KSV.ForeColor = System.Drawing.Color.Teal;
            this.btnPT3KSA_KSV.Location = new System.Drawing.Point(54, 77);
            this.btnPT3KSA_KSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnPT3KSA_KSV.Name = "btnPT3KSA_KSV";
            this.btnPT3KSA_KSV.Size = new System.Drawing.Size(456, 48);
            this.btnPT3KSA_KSV.TabIndex = 0;
            this.btnPT3KSA_KSV.Text = "    PHƯƠNG THỨC 3 (KSA VÀ KSV)";
            this.btnPT3KSA_KSV.UseVisualStyleBackColor = true;
            this.btnPT3KSA_KSV.Click += new System.EventHandler(this.btnPT3KSA_KSV_Click);
            // 
            // picsv
            // 
            this.picsv.Image = ((System.Drawing.Image)(resources.GetObject("picsv.Image")));
            this.picsv.Location = new System.Drawing.Point(0, 117);
            this.picsv.Margin = new System.Windows.Forms.Padding(2);
            this.picsv.Name = "picsv";
            this.picsv.Size = new System.Drawing.Size(572, 660);
            this.picsv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsv.TabIndex = 102;
            this.picsv.TabStop = false;
            // 
            // frmChon_Phuong_Thuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 773);
            this.Controls.Add(this.pnlvien);
            this.Controls.Add(this.picsv);
            this.Controls.Add(this.pnlkhung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChon_Phuong_Thuc";
            this.Text = "frmChon_Phuong_Thuc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChon_Phuong_Thuc_FormClosed);
            this.pnlvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoueh)).EndInit();
            this.pnlkhung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlvien;
        private System.Windows.Forms.PictureBox piclogoueh;
        private System.Windows.Forms.Label lblchonpt;
        private System.Windows.Forms.PictureBox picsv;
        private System.Windows.Forms.Panel pnlkhung;
        private System.Windows.Forms.Button btnPT3KSA_KSV;
        private System.Windows.Forms.Button btnPT5;
        private System.Windows.Forms.Button btnPT4ASEAN_ISB;
        private System.Windows.Forms.Button btnPT4KSA_KSV;
        private System.Windows.Forms.Button btnPT3ASEAN_ISB;
        private System.Windows.Forms.Button btnTV;
    }
}