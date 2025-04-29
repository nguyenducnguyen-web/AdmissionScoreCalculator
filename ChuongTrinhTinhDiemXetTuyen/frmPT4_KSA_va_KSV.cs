using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanC_.frmKetQuaTHPT;

namespace DoanC_
{
    public partial class frmPT4_KSA_va_KSV : Form
    {
        private DuLieu dulieuueh;

        public frmPT4_KSA_va_KSV(DuLieu dulieuueh)
        {
            InitializeComponent();
            this.dulieuueh = dulieuueh;

        }


        private void btnTTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbothm.Text))
            {
                MessageBox.Show("Vui lòng chọn khối trước khi tính điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            double DTBLOP10, DTBLOP11, DTBLOP12;
            double DTB10 = double.Parse(lbl10.Text);

            if (DTB10 >= 6.50 && DTB10 <= 6.99)
            {
                DTBLOP10 = 14;
            }
            else if (DTB10 >= 7.00 && DTB10 <= 7.49)
            {
                DTBLOP10 = 15;
            }
            else if (DTB10 >= 7.50 && DTB10 <= 7.99)
            {
                DTBLOP10 = 16;
            }
            else if (DTB10 >= 8.00 && DTB10 <= 8.49)
            {
                DTBLOP10 = 17;
            }
            else if (DTB10 >= 8.50 && DTB10 <= 8.99)
            {
                DTBLOP10 = 18;
            }
            else if (DTB10 >= 9.00 && DTB10 <= 9.49)
            {
                DTBLOP10 = 19;
            }
            else if (DTB10 >= 9.50 && DTB10 <= 10.0)
            {
                DTBLOP10 = 20;
            }
            else
            {
                DTBLOP10 = 0;
            }

            double DTB11 = double.Parse(lbl11.Text);
            if (DTB11 >= 6.50 && DTB11 <= 6.99)
            {
                DTBLOP11 = 14;
            }
            else if (DTB11 >= 7.00 && DTB11 <= 7.49)
            {
                DTBLOP11 = 15;
            }
            else if (DTB11 >= 7.50 && DTB11 <= 7.99)
            {
                DTBLOP11 = 16;
            }
            else if (DTB11 >= 8.00 && DTB11 <= 8.49)
            {
                DTBLOP11 = 17;
            }
            else if (DTB11 >= 8.50 && DTB11 <= 8.99)
            {
                DTBLOP11 = 18;
            }
            else if (DTB11 >= 9.00 && DTB11 <= 9.49)
            {
                DTBLOP11 = 19;
            }
            else if (DTB11 >= 9.50 && DTB11 <= 10.0)
            {
                DTBLOP11 = 20;
            }
            else
            {
                DTBLOP11 = 0;
            }

            double DTB12 = double.Parse(lbl12.Text);
            if (DTB12 >= 6.50 && DTB12 <= 6.99)
            {
                DTBLOP12 = 9;
            }
            else if (DTB12 >= 7.00 && DTB12 <= 7.49)
            {
                DTBLOP12 = 10;
            }
            else if (DTB12 >= 7.50 && DTB12 <= 7.99)
            {
                DTBLOP12 = 11;
            }
            else if (DTB12 >= 8.00 && DTB12 <= 8.49)
            {
                DTBLOP12 = 12;
            }
            else if (DTB12 >= 8.50 && DTB12 <= 8.99)
            {
                DTBLOP12 = 13;
            }
            else if (DTB12 >= 9.00 && DTB12 <= 9.49)
            {
                DTBLOP12 = 14;
            }
            else if (DTB12 >= 9.50 && DTB12 <= 10.0)
            {
                DTBLOP12 = 15;
            }
            else
            {
                DTBLOP12 = 0;
            }
            double DIEMIELTS;
            string DIELTS = cboIELTS.Text;
            if (DIELTS == "IELTS Academic 9,0 hoặc TOEFL iBT 118-120")
            {
                DIEMIELTS = 20;
            }
            else if (DIELTS == "IELTS Academic 8,5 hoặc TOEFL iBT 115-117")
            {
                DIEMIELTS = 20;
            }
            else if (DIELTS == "IELTS Academic 8,0 hoặc TOEFL iBT 112-114")
            {
                DIEMIELTS = 20;
            }
            else if (DIELTS == "IELTS Academic 7,5 hoặc TOEFL iBT 105-111")
            {
                DIEMIELTS = 18;
            }
            else if (DIELTS == "IELTS Academic 7,0 hoặc TOEFL iBT 96-104")
            {
                DIEMIELTS = 16;
            }
            else if (DIELTS == "IELTS Academic 6,5 hoặc TOEFL iBT 85-95")
            {
                DIEMIELTS = 14;
            }
            else if (DIELTS == "IELTS Academic 6,0 hoặc TOEFL iBT 73-84")
            {
                DIEMIELTS = 12;
            }
            else
            {
                DIEMIELTS = 0;
            }

            double DIEMHSG;
            string HSG = cboHSG.Text;
            if (HSG == "Giải nhất")
            {
                DIEMHSG = 20;
            }
            else if (HSG == "Giải nhì")
            {
                DIEMHSG = 15;
            }
            else if (HSG == "Giải ba")
            {
                DIEMHSG = 10;
            }
            else
            {
                DIEMHSG = 0;
            }

            double DIEMTC = 0;
            if (chk10.Checked)
            {
                DIEMTC += 2;
            }
            if (chk11.Checked)
            {
                DIEMTC += 2;
            }
            if (chk12.Checked)
            {
                DIEMTC += 1;
            }


            double DIEMDT;
            string DTUT = cboDTUT.Text;
            if (DTUT == "Đối tượng 1")
            {
                DIEMDT = 6.67;
            }
            else if (DTUT == "Đối tượng 2")
            {
                DIEMDT = 6.67;
            }
            else if (DTUT == "Đối tượng 3")
            {
                DIEMDT = 6.67;
            }
            else if (DTUT == "Đối tượng 4")
            {
                DIEMDT = 6.67;
            }
            else if (DTUT == "Đối tượng 5")
            {
                DIEMDT = 3.33;
            }
            else if (DTUT == "Đối tượng 6")
            {
                DIEMDT = 3.33;
            }
            else if (DTUT == "Đối tượng 7")
            {
                DIEMDT = 3.33;
            }
            else
            {
                DIEMDT = 0;
            }

            double DIEMKV;
            string KVUT = cboKVUT.Text;
            if (KVUT == "KV1")
            {
                DIEMKV = 2.5;
            }
            else if (KVUT == "KV2-NT")
            {
                DIEMKV = 1.67;
            }
            else if (KVUT == "KV2")
            {
                DIEMKV = 0.83;
            }
            else if (KVUT == "KV3")
            {
                DIEMKV = 0;
            }
            else
            {
                DIEMKV = 0;
            }

            double TONGD1, DIEMUT, TONGD2;
            TONGD1 = DTBLOP10 + DTBLOP11 + DTBLOP12 + DIEMIELTS + DIEMHSG + DIEMTC;

            if (TONGD1 >= 75)
            {
                DIEMUT = ((100 - TONGD1) / 25) * (DIEMDT + DIEMKV);
                TONGD2 = TONGD1 + DIEMUT;
            }
            else
            {
                DIEMUT = DIEMDT + DIEMKV;
                TONGD2 = TONGD1 + DIEMUT;
            }
            lblKQ.Text = TONGD2.ToString("N2");

        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmChon_Phuong_Thuc fr = new frmChon_Phuong_Thuc(dulieuueh);
            this.Hide();
            fr.ShowDialog();

        }

        private void cbnthm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedthm = cbothm.SelectedItem.ToString();
            string result;

            if (selectedthm == "A00")
            {
                result = dulieuueh.A00_10.ToString("N2");
                lbl10.Text = result;
                result = dulieuueh.A00_11.ToString("N2");
                lbl11.Text = result;
                result = dulieuueh.A00_11.ToString("N2");
                lbl12.Text = result;


            }
            else if (selectedthm == "A01")
            {
                result = dulieuueh.A01_10.ToString("N2");
                lbl10.Text = result;
                result = dulieuueh.A01_11.ToString("N2");
                lbl11.Text = result;
                result = dulieuueh.A01_12.ToString("N2");
                lbl12.Text = result;

            }

            else if (selectedthm == "D01")
            {
                result = dulieuueh.D01_10.ToString("N2");
                lbl10.Text = result;
                result = dulieuueh.D01_11.ToString("N2");
                lbl11.Text = result;
                result = dulieuueh.D01_12.ToString("N2");
                lbl12.Text = result;

            }

            else if (selectedthm == "D07")
            {
                result = dulieuueh.D07_10.ToString("N2");
                lbl10.Text = result;
                result = dulieuueh.D07_11.ToString("N2");
                lbl11.Text = result;
                result = dulieuueh.D07_12.ToString("N2");
                lbl12.Text = result;

            }

        }

        private void frmPT4_KSA_va_KSV_Load(object sender, EventArgs e)
        {
            
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void frmPT4_KSA_va_KSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

    }
}

