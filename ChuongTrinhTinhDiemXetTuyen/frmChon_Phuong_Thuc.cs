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
    public partial class frmChon_Phuong_Thuc : Form
    {
        public frmChon_Phuong_Thuc( DuLieu dulieuueh)
        {
            InitializeComponent();
            this.dulieuueh = dulieuueh;
        }
        private DuLieu dulieuueh;
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPT3KSA_KSV_Click(object sender, EventArgs e)
        {
            frmPT3_KSA_va_KSV fr = new frmPT3_KSA_va_KSV(dulieuueh);
            this.Hide();
            fr.ShowDialog();
        }

        private void btnPT3ASEAN_ISB_Click(object sender, EventArgs e)
        {
            frmPT3_Asean_va_ISB fr = new frmPT3_Asean_va_ISB(dulieuueh);
            this.Hide();
            fr.ShowDialog();
        }

        private void btnPT4KSA_KSV_Click(object sender, EventArgs e)
        {
            frmPT4_KSA_va_KSV frm = new frmPT4_KSA_va_KSV(dulieuueh);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnPT4ASEAN_ISB_Click(object sender, EventArgs e)
        {
            frmPT4_Asean_va_ISB fr = new frmPT4_Asean_va_ISB(dulieuueh);
            this.Hide();
            fr.ShowDialog();
        }

        private void btnPT5_Click(object sender, EventArgs e)
        {
            frmPT5_KQ_DGNL fr = new frmPT5_KQ_DGNL(dulieuueh);
            this.Hide();
            fr.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmTrang_Chu fr= new frmTrang_Chu();
            this.Hide();
            fr.ShowDialog();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmTrang_Chu fr = new frmTrang_Chu();
            this.Hide();
            fr.ShowDialog();

        }


        private void frmChon_Phuong_Thuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
