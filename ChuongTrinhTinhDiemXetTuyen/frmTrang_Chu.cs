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
    public partial class frmTrang_Chu : Form
    {


        public frmTrang_Chu()
        {
            InitializeComponent();
        }

        private void btntinhdiemufm_Click(object sender, EventArgs e)
        {
            frmKetQuaTHPT fr = new frmKetQuaTHPT();
            this.Hide();
            fr.ShowDialog();

        }

        private void btntinhdiemueh_Click(object sender, EventArgs e)
        {
            frmNhapdiemUEH fr = new frmNhapdiemUEH();
            this.Hide();
            fr.ShowDialog();
        }

        private void pnlbackground_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void frmTrang_Chu_Load(object sender, EventArgs e)
        {

        }
    }
}
