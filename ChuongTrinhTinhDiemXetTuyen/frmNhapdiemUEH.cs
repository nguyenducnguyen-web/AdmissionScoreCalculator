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
using static DoanC_.frmNhapdiemUEH;

namespace DoanC_
{
    public partial class frmNhapdiemUEH : Form
    {
        public frmNhapdiemUEH()
        {
            InitializeComponent();
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
            nud.ValueChanged += NumericUpDown_ValueChanged; // Làm tròn giá trị 
        }

        private void NumericUpDown_Chon(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nud.Select(0, nud.Text.Length); // Chọn toàn bộ văn bản trong ô nhập liệu
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            decimal roundedValue = Math.Round(nud.Value, 2); // Làm tròn giá trị với một chữ số thập phân
            nud.Value = roundedValue; // Gán giá trị đã làm tròn lại cho NumericUpdown
        }

        private void frmNhapdiemUEH_Load(object sender, EventArgs e)
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
        public class DuLieuueh
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
        private void btnchonphuongthuc_Click(object sender, EventArgs e)
        {
            // GÁN TB MÔN NĂM 10
            float a00_10 = TBMon((float)nudT10.Value, (float)nudVl10.Value, (float)nudHH10.Value);
            float a01_10 = TBMon((float)nudT10.Value, (float)nudVl10.Value, (float)nudTA10.Value);
            float d01_10 = TBMon((float)nudT10.Value, (float)nudNV10.Value, (float)nudTA10.Value);
            float d07_10 = TBMon((float)nudT10.Value, (float)nudHH10.Value, (float)nudTA10.Value);


            // GÁN TB MÔN NĂM 11

            float a00_11 = TBMon((float)nudT11.Value, (float)nudVL11.Value, (float)nudHH11.Value);
            float a01_11 = TBMon((float)nudT11.Value, (float)nudVL11.Value, (float)nudTA11.Value);
            float d01_11 = TBMon((float)nudT11.Value, (float)nudNV11.Value, (float)nudTA11.Value);
            float d07_11 = TBMon((float)nudT11.Value, (float)nudHH11.Value, (float)nudTA11.Value);


            // GÁN MÔN HK1 NĂM 12

            float a00_12 = TBMon((float)nudT12.Value, (float)nudVL12.Value, (float)nudHH12.Value);
            float a01_12 = TBMon((float)nudT12.Value, (float)nudVL12.Value, (float)nudTA12.Value);
            float d01_12 = TBMon((float)nudT12.Value, (float)nudNV12.Value, (float)nudTA12.Value);
            float d07_12 = TBMon((float)nudT12.Value, (float)nudHH12.Value, (float)nudTA12.Value);
            // Nơi lưu các dữ liệu
            DuLieu dulieuueh = new DuLieu
            {
                //TB MÔN NĂM 10
                A00_10 = a00_10,
                A01_10 = a01_10,
                D01_10 = d01_10,
                D07_10 = d07_10,
                //TB MÔN NĂM 11
                A00_11 = a00_11,
                A01_11 = a01_11,
                D01_11 = d01_11,
                D07_11 = d07_11,
                //TB MÔN NĂM 12
                A00_12 = a00_12,
                A01_12 = a01_12,
                D01_12 = d01_12,
                D07_12 = d07_12
            };
            frmChon_Phuong_Thuc fr = new frmChon_Phuong_Thuc(dulieuueh);
            this.Hide();
            fr.ShowDialog();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmTrang_Chu fr = new frmTrang_Chu();
            this.Hide();
            fr.ShowDialog();
        }

        private void frmNhapdiemUEH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
