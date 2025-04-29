using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanC_.frmKetQuaTHPT;

namespace DoanC_
{
    public partial class frmPT3_Asean_va_ISB : Form
    {
        private DuLieu dulieuueh;

        public frmPT3_Asean_va_ISB(DuLieu dulieuueh)
        {
            InitializeComponent();
            this.dulieuueh = dulieuueh;

        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmChon_Phuong_Thuc fr = new frmChon_Phuong_Thuc(dulieuueh);
            this.Hide();
            fr.ShowDialog();

        }

        private void cboKVUT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTTD_Click(object sender, EventArgs e)
        {
            double DTBLOP10, DTBLOP11, DTBLOP12;
            string DTB10 = cbo10.Text;

            // Logic for calculating diemThuong based on placement:
            if (DTB10 == "8,00 - 8,49")
            {
                DTBLOP10 = 17;
            }
            else if (DTB10 == "8,50 - 8,99")
            {
                DTBLOP10 = 18;
            }
            else if (DTB10 == "9,00 - 9,49")
            {
                DTBLOP10 = 19;
            }
            else if (DTB10 == "9,50 - 10,0")
            {
                DTBLOP10 = 20;
            }
            else
            {
                DTBLOP10 = 0;
            }

            string DTB11 = cbo11.Text;
            if (DTB11 == "8,00 - 8,49")
            {
                DTBLOP11 = 17;
            }
            else if (DTB11 == "8,50 - 8,99")
            {
                DTBLOP11 = 18;
            }
            else if (DTB11 == "9,00 - 9,49")
            {
                DTBLOP11 = 19;
            }
            else if (DTB11 == "9,50 - 10,0")
            {
                DTBLOP11 = 20;
            }
            else
            {
                DTBLOP11 = 0;
            }

            string DTB12 = cbo12.Text;
            if (DTB12 == "8,00 - 8,49")
            {
                DTBLOP12 = 12;
            }
            else if (DTB12 == "8,50 - 8,99")
            {
                DTBLOP12 = 13;
            }
            else if (DTB12 == "9,00 - 9,49")
            {
                DTBLOP12 = 14;
            }
            else if (DTB12 == "9,50 - 10,0")
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
                DIEMIELTS = 25;
            }
            else if (DIELTS == "IELTS Academic 8,5 hoặc TOEFL iBT 115-117")
            {
                DIEMIELTS = 25;
            }
            else if (DIELTS == "IELTS Academic 8,0 hoặc TOEFL iBT 112-114")
            {
                DIEMIELTS = 25;
            }
            else if (DIELTS == "IELTS Academic 7,5 hoặc TOEFL iBT 105-111")
            {
                DIEMIELTS = 24;
            }
            else if (DIELTS == "IELTS Academic 7,0 hoặc TOEFL iBT 96-104")
            {
                DIEMIELTS = 23;
            }
            else if (DIELTS == "IELTS Academic 6,5 hoặc TOEFL iBT 85-95")
            {
                DIEMIELTS = 22;
            }
            else if (DIELTS == "IELTS Academic 6,0 hoặc TOEFL iBT 73-84")
            {
                DIEMIELTS = 21;
            }
            else
            {
                DIEMIELTS = 0;
            }

            double DIEMHSG;
            string HSG = cboHSG.Text;
            if (HSG == "Giải nhất")
            {
                DIEMHSG = 5;
            }
            else if (HSG == "Giải nhì")
            {
                DIEMHSG = 4;
            }
            else if (HSG == "Giải ba")
            {
                DIEMHSG = 3;
            }
            else
            {
                DIEMHSG = 0;
            }

            double DIEMTC = 0;
            if (chk10.Checked)
            {
                DIEMTC += 6;
            }
            if (chk11.Checked)
            {
                DIEMTC += 6;
            }
            if (chk12.Checked)
            {
                DIEMTC += 3;
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

        private void frmPT3_Asean_va_ISB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

       
    }
    
}
