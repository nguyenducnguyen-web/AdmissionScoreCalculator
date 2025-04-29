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
    public partial class frmDiemToHop : Form
    {
        public frmDiemToHop()
        {
            InitializeComponent();
            font();


        }
        private void dgvDiemTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void font()
        {
            dgvDiemTH.EnableHeadersVisualStyles = false; // Đảm bảo rằng kiểu header tùy chỉnh được áp dụng
            dgvDiemTH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiemTH.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
        }

        private DuLieu dulieu;
        public frmDiemToHop(DuLieu dulieu)
        {
            InitializeComponent();
            this.dulieu = dulieu;
            Thanhphantohopxt();

            
        }
        private void Thanhphantohopxt()
        {
            // Khởi tạo mảng data với dữ liệu từ dulieu
            (string, string, string, string)[] data = new[]
            {
                ("A00 (Toán, Vật Lí, Hóa Học)", dulieu.DiemToHopA00.ToString("N2"), dulieu.CongA00.ToString("N2"), dulieu.DTA00.ToString("N2")),
                ("A01 (Toán, Vật Lí, Tiếng Anh)", dulieu.DiemToHopA01.ToString("N2"), dulieu.CongA01.ToString("N2"), dulieu.DTA01.ToString("N2")),
                ("D01 (Toán, Ngữ Văn, Tiếng Anh)", dulieu.DiemToHopD01.ToString("N2"), dulieu.CongD01.ToString("N2"), dulieu.DTD01.ToString("N2")),
                ("D07 (Toán, Hóa Học, Tiếng Anh)", dulieu.DiemToHopD07.ToString("N2"), dulieu.CongD07.ToString("N2"), dulieu.DTD07.ToString("N2")),
                ("D72 (Ngữ văn, Tiếng Anh, Khoa học tự nhiên)", dulieu.DiemToHopD72.ToString("N2"), dulieu.CongD72.ToString("N2"), dulieu.DTD72.ToString("N2")),
                ("D78 (Ngữ văn, Tiếng Anh, Khoa học xã hội)", dulieu.DiemToHopD78.ToString("N2"), dulieu.CongD78.ToString("N2"), dulieu.DTD78.ToString("N2")),
                ("D96 (Toán, Tiếng Anh, Khoa học xã hội)", dulieu.DiemToHopD96.ToString("N2"), dulieu.CongD96.ToString("N2"), dulieu.DTD96.ToString("N2"))
            };

            // Sắp xếp dữ liệu theo thứ tự giảm dần của cột DT (Item4)
            Array.Sort(data, (x, y) =>
            {
                double xDT, yDT;
                if (!double.TryParse(x.Item4, out xDT))
                    xDT = double.MinValue; // Đặt giá trị mặc định nếu chuyển đổi không thành công
                if (!double.TryParse(y.Item4, out yDT))
                    yDT = double.MinValue; // Đặt giá trị mặc định nếu chuyển đổi không thành công
                return yDT.CompareTo(xDT);
            });

            // Xóa các dòng hiện tại trong DataGridView trước khi thêm dữ liệu mới
            dgvDiemTH.Rows.Clear();

            // Thêm dữ liệu đã được sắp xếp vào DataGridView
            foreach (var item in data)
            {
                dgvDiemTH.Rows.Add(item.Item1, item.Item2, item.Item3, item.Item4);
            }
        }

        private void btndkxt_Click(object sender, EventArgs e)
        {
            frmChonPhuongThucXT frm = new frmChonPhuongThucXT(dulieu);
            this.Hide();
            frm.ShowDialog();



        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmKetQuaTHPT fr = new frmKetQuaTHPT();
            this.Hide();
            fr.ShowDialog();
        }

        private void frmDiemToHop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
    
}
