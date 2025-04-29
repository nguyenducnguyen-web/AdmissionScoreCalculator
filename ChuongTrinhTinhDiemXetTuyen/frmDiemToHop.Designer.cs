namespace DoanC_
{
    partial class frmDiemToHop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemToHop));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbldiemxt = new System.Windows.Forms.Label();
            this.lblUFM = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.picbackground = new System.Windows.Forms.PictureBox();
            this.dgvDiemTH = new System.Windows.Forms.DataGridView();
            this.dgv_cot_tohopxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cot_tohop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cot_kvut_dtut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cot_tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltv = new System.Windows.Forms.Label();
            this.btnTV = new System.Windows.Forms.Button();
            this.btndkxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldiemxt
            // 
            this.lbldiemxt.AutoSize = true;
            this.lbldiemxt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldiemxt.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbldiemxt.Location = new System.Drawing.Point(453, 174);
            this.lbldiemxt.Name = "lbldiemxt";
            this.lbldiemxt.Size = new System.Drawing.Size(256, 32);
            this.lbldiemxt.TabIndex = 77;
            this.lbldiemxt.Text = "ĐIỂM XÉT TUYỂN";
            this.lbldiemxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUFM
            // 
            this.lblUFM.AutoSize = true;
            this.lblUFM.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUFM.ForeColor = System.Drawing.Color.White;
            this.lblUFM.Image = global::DoanC_.Properties.Resources.back;
            this.lblUFM.Location = new System.Drawing.Point(293, 14);
            this.lblUFM.Name = "lblUFM";
            this.lblUFM.Size = new System.Drawing.Size(740, 74);
            this.lblUFM.TabIndex = 76;
            this.lblUFM.Text = "TRƯỜNG ĐẠI HỌC TÀI CHÍNH - MARKETING\r\nSáng tạo - Khác biệt - Hiệu quả - Bền vững\r" +
    "\n";
            this.lblUFM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // piclogo
            // 
            this.piclogo.BackColor = System.Drawing.Color.Transparent;
            this.piclogo.BackgroundImage = global::DoanC_.Properties.Resources.back;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(-1, -2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(210, 157);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 75;
            this.piclogo.TabStop = false;
            // 
            // picbackground
            // 
            this.picbackground.BackColor = System.Drawing.Color.Lavender;
            this.picbackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbackground.Image = ((System.Drawing.Image)(resources.GetObject("picbackground.Image")));
            this.picbackground.Location = new System.Drawing.Point(-34, -2);
            this.picbackground.Name = "picbackground";
            this.picbackground.Size = new System.Drawing.Size(1914, 157);
            this.picbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbackground.TabIndex = 74;
            this.picbackground.TabStop = false;
            // 
            // dgvDiemTH
            // 
            this.dgvDiemTH.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue;
            this.dgvDiemTH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiemTH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemTH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemTH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiemTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemTH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_cot_tohopxt,
            this.dgv_cot_tohop,
            this.dgv_cot_kvut_dtut,
            this.dgv_cot_tong});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemTH.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDiemTH.Location = new System.Drawing.Point(63, 220);
            this.dgvDiemTH.Name = "dgvDiemTH";
            this.dgvDiemTH.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.dgvDiemTH.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDiemTH.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkBlue;
            this.dgvDiemTH.RowTemplate.Height = 24;
            this.dgvDiemTH.Size = new System.Drawing.Size(1014, 363);
            this.dgvDiemTH.TabIndex = 78;
            this.dgvDiemTH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemTH_CellContentClick);
            // 
            // dgv_cot_tohopxt
            // 
            this.dgv_cot_tohopxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.dgv_cot_tohopxt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cot_tohopxt.FillWeight = 17F;
            this.dgv_cot_tohopxt.HeaderText = "TỔ HỢP XÉT TUYỂN";
            this.dgv_cot_tohopxt.MinimumWidth = 10;
            this.dgv_cot_tohopxt.Name = "dgv_cot_tohopxt";
            // 
            // dgv_cot_tohop
            // 
            this.dgv_cot_tohop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.dgv_cot_tohop.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_cot_tohop.FillWeight = 8F;
            this.dgv_cot_tohop.HeaderText = "ĐIỂM TỔ HỢP";
            this.dgv_cot_tohop.MinimumWidth = 10;
            this.dgv_cot_tohop.Name = "dgv_cot_tohop";
            // 
            // dgv_cot_kvut_dtut
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.dgv_cot_kvut_dtut.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_cot_kvut_dtut.FillWeight = 6.048218F;
            this.dgv_cot_kvut_dtut.HeaderText = "ĐIỂM KHU VỰC ƯU TIÊN, ĐỐI TƯỢNG";
            this.dgv_cot_kvut_dtut.MinimumWidth = 10;
            this.dgv_cot_kvut_dtut.Name = "dgv_cot_kvut_dtut";
            this.dgv_cot_kvut_dtut.Width = 170;
            // 
            // dgv_cot_tong
            // 
            this.dgv_cot_tong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.dgv_cot_tong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_cot_tong.FillWeight = 6.048218F;
            this.dgv_cot_tong.HeaderText = "TỔNG";
            this.dgv_cot_tong.MinimumWidth = 10;
            this.dgv_cot_tong.Name = "dgv_cot_tong";
            // 
            // lbltv
            // 
            this.lbltv.AutoSize = true;
            this.lbltv.BackColor = System.Drawing.Color.White;
            this.lbltv.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltv.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbltv.Location = new System.Drawing.Point(898, 651);
            this.lbltv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltv.Name = "lbltv";
            this.lbltv.Size = new System.Drawing.Size(119, 15);
            this.lbltv.TabIndex = 123;
            this.lbltv.Text = "Trở về kết quả THPT";
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTV.ForeColor = System.Drawing.Color.White;
            this.btnTV.Location = new System.Drawing.Point(872, 668);
            this.btnTV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(170, 33);
            this.btnTV.TabIndex = 122;
            this.btnTV.Text = "Click vào đây!";
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btndkxt
            // 
            this.btndkxt.BackColor = System.Drawing.Color.Red;
            this.btndkxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndkxt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndkxt.ForeColor = System.Drawing.Color.White;
            this.btndkxt.Location = new System.Drawing.Point(336, 651);
            this.btndkxt.Name = "btndkxt";
            this.btndkxt.Size = new System.Drawing.Size(421, 43);
            this.btndkxt.TabIndex = 121;
            this.btndkxt.Text = "ĐĂNG KÝ XÉT TUYỂN";
            this.btndkxt.UseVisualStyleBackColor = false;
            this.btndkxt.Click += new System.EventHandler(this.btndkxt_Click);
            // 
            // frmDiemToHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 734);
            this.Controls.Add(this.lbltv);
            this.Controls.Add(this.btnTV);
            this.Controls.Add(this.btndkxt);
            this.Controls.Add(this.dgvDiemTH);
            this.Controls.Add(this.lbldiemxt);
            this.Controls.Add(this.lblUFM);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.picbackground);
            this.Name = "frmDiemToHop";
            this.Text = "frmDiemToHop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDiemToHop_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldiemxt;
        private System.Windows.Forms.Label lblUFM;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.PictureBox picbackground;
        private System.Windows.Forms.DataGridView dgvDiemTH;
        private System.Windows.Forms.Label lbltv;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btndkxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_cot_tohopxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_cot_tohop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_cot_kvut_dtut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_cot_tong;
    }
}