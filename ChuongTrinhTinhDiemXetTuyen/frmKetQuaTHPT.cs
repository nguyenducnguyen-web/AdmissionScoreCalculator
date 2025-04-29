using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanC_.frmKetQuaTHPT;

namespace DoanC_
{
    public partial class frmKetQuaTHPT : Form
    {


        public frmKetQuaTHPT()
        {
            InitializeComponent();

        }

        private void txtdiemcc_TextChanged(object sender, EventArgs e)
        {
            string loaicc = cbocc_nn.Text;
            float diemqd = 0;
            float diemcc;

            if (float.TryParse(txtdiemcc.Text, out diemcc))
            {
                switch (loaicc)
                {
                    case "IELTS (Academic)":
                        {
                            if (diemcc >= 4.0 && diemcc <= 5.5)
                            {
                                diemqd = 8;
                            }
                            else if (diemcc >= 5.5 && diemcc <= 6.5)
                            {
                                diemqd = 9;
                            }
                            else if (diemcc >= 7.0 && diemcc <= 9.0)
                            {
                                diemqd = 10;
                            }
                        }
                        break;
                    case "TOEFL iBT":
                        {
                            if (diemcc >= 30 && diemcc <= 45)
                            {
                                diemqd = 8;
                            }
                            else if (diemcc >= 46 && diemcc <= 93)
                            {
                                diemqd = 9;
                            }
                            else if (diemcc >= 94 && diemcc <= 120)
                            {
                                diemqd = 10;
                            }
                        }
                        break;
                    case "TOEFL ITP":
                        {
                            if (diemcc >= 450 && diemcc <= 499)
                            {
                                diemqd = 8;
                            }
                            else if (diemcc >= 500 && diemcc <= 626)
                            {
                                diemqd = 9;
                            }
                            else if (diemcc >= 627 && diemcc <= 677)
                            {
                                diemqd = 10;
                            }
                        }
                        break;
                    case "TOEIC (listening and reading)":
                        {
                            if (diemcc >= 550 && diemcc <= 780)
                            {
                                diemqd = 8;
                            }
                            else if (diemcc >= 785 && diemcc <= 940)
                            {
                                diemqd = 9;
                            }
                            else if (diemcc >= 945 && diemcc <= 990)
                            {
                                diemqd = 10;
                            }
                        }
                        break;
                    case "Khung NLNN 6 bậc dùng cho Việt Nam":
                        {
                            if (diemcc >= 4.0 && diemcc <= 5.5)
                            {
                                diemqd = 8;
                            }
                            else if (diemcc >= 6.0 && diemcc <= 8.0)
                            {
                                diemqd = 9;
                            }
                            else if (diemcc >= 8.5 && diemcc <= 10)
                            {
                                diemqd = 10;
                            }
                        }
                        break;
                    case "Cambridge Assessment English - Linguaskill ":
                        {
                            if (diemcc >= 140 && diemcc <= 159)
                            {
                                diemqd = 8;
                            }
                            else if (diemcc >= 160 && diemcc <= 179)
                            {
                                diemqd = 9;
                            }
                            else if (diemcc >= 180)
                            {
                                diemqd = 10;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (loaicc == "Aptis ESOL International Certificate")
            {
                string diem = txtdiemcc.Text.ToUpper();

                if (diem == "B1")
                {
                    diemqd = 8;
                }
                else if (diem == "B2")
                {
                    diemqd = 9;
                }
                else if (diem == "C1" || diem == "C2")
                {
                    diemqd = 10;
                }
            }
            else { diemqd = 0; }


            txtdiemqd.Text = diemqd.ToString();
        }



        public float TBMon(params float[] values)
        {

            float sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            float average = sum / values.Length;
            return (float)Math.Round(average, 2);
        }

        private float TinhDiemUuTien(float tongDiemDatDuoc)
        {
            float diemut = 0;
            string dtut = cboDoiTuongUT.Text;
            switch (dtut)
            {
                case "00 - Không thuộc đối tượng ưu tiên":
                    diemut = 0;
                    break;
                case "01 - Đối tượng 01 (Dân tộc thiểu số ở KV1...)":
                case "02 - Đối tượng 02 (Công nhân sản xuất là chiến sĩ thi đua được cấp tỉnh...)":
                case "03 - Đối tượng 03 (Thương binh, bệnh binh, người có công với cách mạng...)":
                case "04 - Đối tượng 04 (Con liệt sỹ, con thương binh từ 81% trở lên...)":
                    diemut = 2;
                    break;
                case "05 - Đối tượng 05 (Thanh niên xung phong, Quân nhân, CAND tại ngũ...)":
                case "06 - Đối tượng 06 (Dân tộc thiểu số ngoài KV1, con thương binh, bệnh binh dưới 81%...)":
                case "07 - Đối tượng 07 (Người khuyết tật nặng...)":
                    diemut = 1;
                    break;
                default:
                    break;
            }

            double diemkvut = 0;
            string kvut = cboKVUT.Text;
            switch (kvut)
            {
                case "KV1":
                    diemkvut = 0.75;
                    break;
                case "KV2":
                    diemkvut = 0.25;
                    break;
                case "KV2 - NT":
                    diemkvut = 0.5;
                    break;
                case "KV3":
                    diemkvut = 0;
                    break;
                default:
                    break;
            }

            double mucDiemUuTien = diemkvut + diemut;
            double diemUuTien = ((30 - tongDiemDatDuoc) / 7.5) * mucDiemUuTien;
            return (float)Math.Round(diemUuTien, 2);
        }
        public class DuLieu
        {
            // GÁN TB MÔN NĂM 10
            public float A00_10 { get; set; }
            public float A01_10 { get; set; }
            public float D01_10 { get; set; }
            public float D07_10 { get; set; }
            // GÁN TB MÔN NĂM 11
            public float A00_11 { get; set; }
            public float A01_11 { get; set; }
            public float D01_11 { get; set; }
            public float D07_11 { get; set; }

            // GÁN MÔN HK1 NĂM 12
            public float A00_12 { get; set; }
            public float A01_12 { get; set; }
            public float D01_12 { get; set; }
            public float D07_12 { get; set; }
            //điểm tb môn
            public float Toan { get; set; }
            public float NV { get; set; }
            public float VL { get; set; }
            public float HH { get; set; }
            public float SH { get; set; }
            public float TA { get; set; }
            public float DL { get; set; }
            public float LS { get; set; }
            public float GDCD { get; set; }
            // điểm tổ hợp 
            public float DiemToHopA00 { get; set; }
            public float DiemToHopD01 { get; set; }
            public float DiemToHopD07 { get; set; }
            public float DiemToHopA01 { get; set; }
            public float DiemToHopD72 { get; set; }
            public float DiemToHopD78 { get; set; }
            public float DiemToHopD96 { get; set; }
            // điểm cộng ưu tiên từng khối
            public float CongA00 { get; set; }
            public float CongD01 { get; set; }
            public float CongD07 { get; set; }
            public float CongA01 { get; set; }
            public float CongD72 { get; set; }
            public float CongD78 { get; set; }
            public float CongD96 { get; set; }
            //điểm tổng
            public float DTA00 { get; set; }
            public float DTA01 { get; set; }
            public float DTD01 { get; set; }
            public float DTD07 { get; set; }
            public float DTD72 { get; set; }
            public float DTD78 { get; set; }
            public float DTD96 { get; set; }
            // điểm tổng nna
            public float NNAD01 { get; set; }
            public float NNAD72 { get; set; }
            public float NNAD78 { get; set; }
            public float NNAD96 { get; set; }

        }
        private void btnXemDiem_Click(object sender, EventArgs e)
        {

            float dtbT = TBMon((float)nudT10.Value, (float)nudT11.Value, (float)nudT12.Value);
            float dtbNV = TBMon((float)nudNV10.Value, (float)nudNV11.Value, (float)nudNV12.Value);
            float dtbVL = TBMon((float)nudVl10.Value, (float)nudVL11.Value, (float)nudVL12.Value);
            float dtbHH = TBMon((float)nudHH10.Value, (float)nudHH11.Value, (float)nudHH12.Value);
            float dtbSH = TBMon((float)nudSH10.Value, (float)nudSH11.Value, (float)nudSH12.Value);
            float dtbTA = TBMon((float)nudTA10.Value, (float)nudTA11.Value, (float)nudTA12.Value);
            // So sánh giá trị điểm quy đổi với điểm trung bình Tiếng Anh, nếu điểm quy đổi lớn hơn thì điểm trung bình tiếng anh = điểm quy đổi.
            if (float.TryParse(txtdiemqd.Text, out float diemqd))
            {
                if (diemqd > dtbTA)
                {
                    dtbTA = diemqd;
                }
            }
            float dtbDL = TBMon((float)nudDL10.Value, (float)nudDL11.Value, (float)nudDL12.Value);
            float dtbLS = TBMon((float)nudLS10.Value, (float)nudLS11.Value, (float)nudLS12.Value);
            float dtbGDCD = TBMon((float)nudGDCD10.Value, (float)nudGDCD11.Value, (float)nudGDCD12.Value);






            /*Cách tính điểm tổ hợp D72, D78, D96:
            D72 = Ngữ văn – Tiếng Anh – Khoa học tự nhiên
            D78 = Ngữ văn – Tiếng Anh – Khoa học xã hội
            D96 = Toán - Tiếng Anh - Khoa học xã hội

            -Khoa học xã hội gồm tổng hợp của 3 môn: 
            Lịch sử - Địa lí - Giáo dục công dân, 
            như vậy điểm môn Khoa học xã hội = (Lịch sử + Địa lí + Giáo dục công dân)/3
            -Khoa học tự nhiên gồm tổ hợp của 3 môn: 
            Vật lí, Hóa học, Sinh học, 
            như vậy điểm môn Khoa học tự nhiên = (Vật lí + Hóa học + Sinh học)/3*/

            //Điểm trung bình môn KHTN
            float khtn = (dtbVL + dtbHH + dtbSH) / 3;
            khtn = (float)Math.Round(khtn, 2);
            //Điểm trung bình môn KHXH
            float khxh = (dtbLS + dtbDL + dtbGDCD) / 3;
            khxh = (float)Math.Round(khxh, 2);
            //Khối A00
            float diemToHopA00 = (dtbT + dtbVL + dtbHH);
            //Khối A01
            float diemToHopA01 = (dtbT + dtbVL + dtbTA);
            //Khối D07
            float diemToHopD07 = (dtbT + dtbHH + dtbTA);
            //Khối D01
            float diemToHopD01 = (dtbT + dtbNV + dtbTA);
            float diemNNAD01 = ((dtbT + dtbNV + dtbTA * 2) * 3) / 4;
            //Khối D72
            float diemToHopD72 = (dtbNV + dtbTA + khtn);
            float diemNNAD72 = ((dtbNV + dtbTA * 2 + khtn) * 3) / 4;

            //Khối D78
            float diemToHopD78 = (dtbNV + dtbTA + khxh);
            float diemNNAD78 = ((dtbNV + dtbTA * 2 + khxh) * 3) / 4;

            //Khối d96
            float diemToHopD96 = (dtbT + dtbTA + khxh);
            float diemNNAD96 = ((dtbNV + dtbTA * 2 + khxh) * 3) / 4;

            // Tính điểm ưu tiên 

            float mucuta00 = TinhDiemUuTien(diemToHopA00);
            float mucuta01 = TinhDiemUuTien(diemToHopA01);
            float mucutd01 = TinhDiemUuTien(diemToHopD01);
            float mucutd07 = TinhDiemUuTien(diemToHopD07);
            float mucutd72 = TinhDiemUuTien(diemToHopD72);
            float mucutd78 = TinhDiemUuTien(diemToHopD78);
            float mucutd96 = TinhDiemUuTien(diemToHopD96);
            //Ngành ngôn ngữ Anh
            float congnnad01 = TinhDiemUuTien(diemNNAD01);
            float congnnad72 = TinhDiemUuTien(diemNNAD72);
            float congnnad78 = TinhDiemUuTien(diemNNAD78);
            float congnnad96 = TinhDiemUuTien(diemNNAD96);
            //Điểm tổng:
            float DTa00 = diemToHopA00 + mucuta00;
            float DTa01 = diemToHopA01 + mucuta01;
            float DTd01 = diemToHopD01 + mucutd01;
            float DTd07 = diemToHopD07 + mucutd07;
            float DTd72 = diemToHopD72 + mucutd72;
            float DTd78 = diemToHopD78 + mucutd78;
            float DTd96 = diemToHopD96 + mucutd96;
            //ngôn ngữ anh
            float dtnnad01 = diemNNAD01 + congnnad01;
            float dtnnad72 = diemNNAD01 + congnnad72;
            float dtnnad78 = diemNNAD01 + congnnad78;
            float dtnnad96 = diemNNAD01 + congnnad96;



            // Nơi lưu các dữ liệu
            DuLieu dulieu = new DuLieu
            {



                //gán điểm trung bình
                Toan = dtbT,
                NV = dtbNV,
                VL = dtbVL,
                HH = dtbHH,
                SH = dtbSH,
                TA = dtbTA,
                DL = dtbDL,
                LS = dtbLS,
                GDCD = dtbGDCD,
                // gán điểm tổ hợp
                DiemToHopA00 = diemToHopA00,
                DiemToHopA01 = diemToHopA01,
                DiemToHopD01 = diemToHopD01,
                DiemToHopD07 = diemToHopD07,
                DiemToHopD72 = diemToHopD72,
                DiemToHopD78 = diemToHopD78,
                DiemToHopD96 = diemToHopD96,
                // gán điểm cộng ưu tiên
                CongA00 = mucuta00,
                CongA01 = mucuta01,
                CongD01 = mucutd01,
                CongD07 = mucutd07,
                CongD72 = mucutd72,
                CongD78 = mucutd78,
                CongD96 = mucutd96,

                //gán điểm tổng
                DTA00 = DTa00,
                DTA01 = DTa01,
                DTD01 = DTd01,
                DTD07 = DTd07,
                DTD72 = DTd72,
                DTD78 = DTd78,
                DTD96 = DTd96,

                //gán điểm tổng NNA
                NNAD01 = dtnnad01,
                NNAD72 = dtnnad72,
                NNAD78 = dtnnad78,
                NNAD96 = dtnnad96

            };
            //Truyền dữ liệu
            frmDiemToHop fr = new frmDiemToHop(dulieu);
            this.Hide();
            fr.ShowDialog();
           
        }





        private void cbnchungchinn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetNumericUpDownProperties(NumericUpDown nud)
        {
            nud.Value = 0;
            nud.DecimalPlaces = 1; // Hiển thị một chữ số thập phân
            nud.Increment = 0.1M; // Khoảng giữa các giá trị là 0.1
            nud.Minimum = 0;
            nud.Maximum = 10;
            nud.Enter += NumericUpDown_Chon;
            nud.Click += NumericUpDown_Chon;
            nud.ValueChanged += NumericUpDown_ValueChanged; 
        }

        private void NumericUpDown_Chon(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nud.Select(0, nud.Text.Length); // Chọn toàn bộ văn bản trong ô nhập liệu
            
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            decimal lamtron = Math.Round(nud.Value, 2);
            nud.Value = lamtron;
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            cbocc_nn.SelectedIndex = -1;
            txtdiemcc.Text = "";
            txtdiemqd.Text = "";

        }

        private void frmKetQuaTHPT_Load(object sender, EventArgs e)
        {
            // Toán
            SetNumericUpDownProperties(nudT10);
            SetNumericUpDownProperties(nudT11);
            SetNumericUpDownProperties(nudT12);
            // Ngữ Văn
            SetNumericUpDownProperties(nudNV10);
            SetNumericUpDownProperties(nudNV11);
            SetNumericUpDownProperties(nudNV12);
            // Vật Lí
            SetNumericUpDownProperties(nudVl10);
            SetNumericUpDownProperties(nudVL11);
            SetNumericUpDownProperties(nudVL12);
            // Hóa học
            SetNumericUpDownProperties(nudHH10);
            SetNumericUpDownProperties(nudHH11);
            SetNumericUpDownProperties(nudHH12);
            // Sinh học 
            SetNumericUpDownProperties(nudSH10);
            SetNumericUpDownProperties(nudSH11);
            SetNumericUpDownProperties(nudSH12);
            // Tiếng Anh
            SetNumericUpDownProperties(nudTA10);
            SetNumericUpDownProperties(nudTA11);
            SetNumericUpDownProperties(nudTA12);
            // Địa Lí
            SetNumericUpDownProperties(nudDL10);
            SetNumericUpDownProperties(nudDL11);
            SetNumericUpDownProperties(nudDL12);
            // Lịch sử
            SetNumericUpDownProperties(nudLS10);
            SetNumericUpDownProperties(nudLS11);
            SetNumericUpDownProperties(nudLS12);
            // Giáo dục công dân
            SetNumericUpDownProperties(nudGDCD10);
            SetNumericUpDownProperties(nudGDCD11);
            SetNumericUpDownProperties(nudGDCD12);
        }

        private void btnTV_Click_1(object sender, EventArgs e)
        {
            frmTrang_Chu fr = new frmTrang_Chu();
            this.Hide();
            fr.ShowDialog();
        }

        private void frmKetQuaTHPT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
