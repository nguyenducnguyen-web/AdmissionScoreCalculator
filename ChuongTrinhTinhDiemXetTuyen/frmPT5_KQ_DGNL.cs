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
    public partial class frmPT5_KQ_DGNL : Form
    {
        private DuLieu dulieuueh;

        
        public frmPT5_KQ_DGNL(DuLieu dulieuueh)
        {
            InitializeComponent();
            this.dulieuueh = dulieuueh;
            this.txtND.KeyPress += new KeyPressEventHandler(this.txtND_KeyPress);


        }
        private void btnTTD_Click(object sender, EventArgs e)
        {
            double DDGNL;
            if (string.IsNullOrWhiteSpace(txtND.Text))
            {
                MessageBox.Show("Vui lòng nhập điểm trước khi tính tổng điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DDGNL=double.Parse(txtND.Text);
            
            if (DDGNL> 1200)
            {
                MessageBox.Show("Điểm thi đánh giá năng lực vượt quá giá trị cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double DIEMDT;
            string DTUT = cboDTUT.Text;
            if (!double.TryParse(txtND.Text, out DDGNL))
            {
                MessageBox.Show("Điểm đánh giá năng lực không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DTUT == "Đối tượng 1")
            {
                DIEMDT = 80;
            }
            else if (DTUT == "Đối tượng 2")
            {
                DIEMDT = 80;
            }
            else if (DTUT == "Đối tượng 3")
            {
                DIEMDT = 80;
            }
            else if (DTUT == "Đối tượng 4")
            {
                DIEMDT = 80;
            }
            else if (DTUT == "Đối tượng 5")
            {
                DIEMDT = 40;
            }
            else if (DTUT == "Đối tượng 6")
            {
                DIEMDT = 40;
            }
            else if (DTUT == "Đối tượng 7")
            {
                DIEMDT = 40;
            }
            else
            {
                DIEMDT = 0;
            }

            double DIEMKV, DIEMUT, TONGD2;
            string KVUT = cboKVUT.Text;
            if (KVUT == "KV1")
            {
                DIEMKV = 30;
            }
            else if (KVUT == "KV2-NT")
            {
                DIEMKV = 20;
            }
            else if (KVUT == "KV2")
            {
                DIEMKV = 10;
            }
            else if (KVUT == "KV3")
            {
                DIEMKV = 0;
            }
            else
            {
                DIEMKV = 0;
            }           

            if (DDGNL >= 900)
            {
                DIEMUT = ((1200 - DDGNL) / 300) * (DIEMDT + DIEMKV);
                TONGD2 = DDGNL + DIEMUT;
            }
            else
            {
                DIEMUT = DIEMDT + DIEMKV;
                TONGD2 = DDGNL + DIEMUT;
            }
            lblKQ.Text = TONGD2.ToString("");
            
            
          

        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmChon_Phuong_Thuc fr = new frmChon_Phuong_Thuc(dulieuueh);
            this.Hide();
            fr.ShowDialog();

        }
        private void txtND_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nhapdiem = txtND.Text;

                // Thử chuyển đổi giá trị nhập vào thành số thực
                if (!float.TryParse(nhapdiem, out float result))
                {
                    // Nếu không chuyển đổi được, hiển thị thông báo lỗi
                    MessageBox.Show("Bạn đã nhập sai, điểm phải là một số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result > 1200)
                {
                    // Nếu giá trị nhập vào lớn hơn 1200, hiển thị thông báo lỗi
                    MessageBox.Show("Điểm không được vượt quá 1200", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void frmPT5_KQ_DGNL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

    }
}
