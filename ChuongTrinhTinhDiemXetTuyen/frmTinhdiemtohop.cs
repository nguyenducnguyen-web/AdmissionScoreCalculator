using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanC_
{
    public partial class frmTinhdiemtohop : Form
    {
        public frmTinhdiemtohop()
        {
            InitializeComponent();
        }

        private void SetNumericUpDownProperties(NumericUpDown nud)
        {
            nud.Minimum = 0;
            nud.Maximum = 10;
            nud.Increment = 0.1M;
            nud.DecimalPlaces = 1;
        }

        private void frmTinhdiemtohop_Load(object sender, EventArgs e)
        {
            //Toán
          SetNumericUpDownProperties(nudT10);
          SetNumericUpDownProperties(nudT11);
          SetNumericUpDownProperties(nudT12);
            //Ngữ Văn
          SetNumericUpDownProperties(nudNV10);
          SetNumericUpDownProperties(nudNV11);
          SetNumericUpDownProperties(nudNV12);
            //Vật Lí
          SetNumericUpDownProperties(nudVl10);
          SetNumericUpDownProperties(nudVL11); 
          SetNumericUpDownProperties(nudVL12);
            //Hóa học
          SetNumericUpDownProperties(nudHH10);
          SetNumericUpDownProperties(nudHH11);
          SetNumericUpDownProperties(nudHH12);
            //Sinh học 
          SetNumericUpDownProperties(nudSH10);
          SetNumericUpDownProperties(nudSH11);
          SetNumericUpDownProperties(nudSH12);
            //Tiếng Anh
          SetNumericUpDownProperties(nudTA10); 
          SetNumericUpDownProperties(nudTA11);
          SetNumericUpDownProperties(nudTA12);
            //Địa Lí
          SetNumericUpDownProperties(nudDL10);
          SetNumericUpDownProperties(nudDL11);
          SetNumericUpDownProperties(nudDL12);
            //Lịch sử
          SetNumericUpDownProperties(nudLS10);
          SetNumericUpDownProperties(nudLS11);
          SetNumericUpDownProperties(nudLS12);
            //Giáo dục công dân
          SetNumericUpDownProperties(nudGDCD10);
          SetNumericUpDownProperties(nudGDCD11);
          SetNumericUpDownProperties(nudGDCD12);
        
        }

        private void lblDTUT_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
