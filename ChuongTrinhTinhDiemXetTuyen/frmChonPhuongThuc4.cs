using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoanC_.frmKetQuaTHPT;

namespace DoanC_
{
    public partial class frmChonPhuongThuc4 : Form
    {
        private DuLieu dulieu;
        public frmChonPhuongThuc4(DuLieu dulieu)
        {
            InitializeComponent();
            this.dulieu = dulieu;
            this.txtND.KeyPress += new KeyPressEventHandler(this.txtND_KeyPress);


        }
        private void frmChonPhuongThuc4_Load(object sender, EventArgs e)
        {

        }
        private void btnTDNL_Click(object sender, EventArgs e)
        {
            float diemut = 0;
            string dtut = cboDTUT.Text;
            if (string.IsNullOrWhiteSpace(txtND.Text))
            {
                MessageBox.Show("Vui lòng nhập điểm trước khi tính tổng điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (dtut)
            {
                case "00 - Không thuộc đối tượng ưu tiên":
                    diemut = 0;
                    break;
                case "01 - Đối tượng 01 (Dân tộc thiểu số ở KV1...)":
                case "02 - Đối tượng 02 (Công nhân sản xuất là chiến sĩ thi đua được cấp tỉnh...)":
                case "03 - Đối tượng 03 (Thương binh, bệnh binh, người có công với cách mạng...)":
                case "04 - Đối tượng 04 (Con liệt sỹ, con thương binh từ 81% trở lên...)":
                    diemut = 80;
                    break;
                case "05 - Đối tượng 05 (Thanh niên xung phong, Quân nhân, CAND tại ngũ...)":
                case "06 - Đối tượng 06 (Dân tộc thiểu số ngoài KV1, con thương binh, bệnh binh dưới 81%...)":
                case "07 - Đối tượng 07 (Người khuyết tật nặng...)":
                    diemut = 40;
                    break;
                default:
                    break;
            }

            double diemkvut = 0;
            string kvut = cboKVUT.Text;
            switch (kvut)
            {
                case "KV1":
                    diemkvut = 30;
                    break;
                case "KV2":
                    diemkvut = 10;
                    break;
                case "KV2 - NT":
                    diemkvut = 20;
                    break;
                case "KV3":
                    diemkvut = 0;
                    break;
                default:
                    break;
            }


            double dgnl;
            if (!double.TryParse(txtND.Text, out dgnl))
            {
                MessageBox.Show("Điểm đánh giá năng lực không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgnl > 1200) 
            {
                MessageBox.Show("Điểm thi đánh giá năng lực vượt quá giá trị cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            else
            {
                double tongdgnl = dgnl + diemkvut + diemut;
                lblKQNL.Text = tongdgnl.ToString("");

            }
             

        }

        private void cboKVUT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void grpvien_Enter(object sender, EventArgs e)
        {

        }

        private void btntv_Click(object sender, EventArgs e)
        {
            frmChonPhuongThucXT fr = new frmChonPhuongThucXT(dulieu);
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
        private void txtND_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmChonPhuongThuc4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void lblKQNL_Click(object sender, EventArgs e)
        {

        }
    }
    
        
    
}
