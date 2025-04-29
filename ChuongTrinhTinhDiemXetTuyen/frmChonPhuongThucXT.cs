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
    public partial class frmChonPhuongThucXT : Form
    {

       
        private DuLieu dulieu;

        public frmChonPhuongThucXT(DuLieu dulieu)
        {
            InitializeComponent();
            this.dulieu = dulieu;
        }
        private void btnpt4_Click(object sender, EventArgs e)
        {
            frmChonPhuongThuc4 frm = new frmChonPhuongThuc4(dulieu);
            frm.ShowDialog();
        }

        private void btnpt2_1_Click(object sender, EventArgs e)
        {
            frmPhuongthuc2_1 frm = new frmPhuongthuc2_1(dulieu);
            this.Hide();
            frm.ShowDialog();

        }

        private void btnpt2_2_Click(object sender, EventArgs e)
        {
            frmPhuongthuc2_2 frm = new frmPhuongthuc2_2(dulieu);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnpt2_3_Click(object sender, EventArgs e)
        {
            frmPhuongthuc2_3 frm = new frmPhuongthuc2_3(dulieu);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnpt2_4_Click(object sender, EventArgs e)
        {
            frmPhuongthuc2_4 frm = new frmPhuongthuc2_4(dulieu);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnpt3_Click(object sender, EventArgs e)
        {
            frmPhuongthuc3 frm = new frmPhuongthuc3(dulieu);
            this.Hide();
            frm.ShowDialog();
        }

    

        private void grpchon_Enter(object sender, EventArgs e)
        {

        }

        private void lbltv_Click(object sender, EventArgs e)
        {

        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmDiemToHop frm = new frmDiemToHop(dulieu);
            this.Hide();
            frm.ShowDialog();


        }

        private void btnpt4_Click_1(object sender, EventArgs e)
        {
            frmChonPhuongThuc4 frm = new frmChonPhuongThuc4(dulieu);
            this.Hide();
            frm.ShowDialog();
        }

        private void frmChonPhuongThucXT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
