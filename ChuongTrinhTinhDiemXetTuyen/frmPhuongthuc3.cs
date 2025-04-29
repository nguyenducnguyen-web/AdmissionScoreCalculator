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
    public partial class frmPhuongthuc3 : Form
    {
        private DuLieu dulieu;
        public frmPhuongthuc3(DuLieu dulieu)
        {
            InitializeComponent();
            InitializeData();
            this.dulieu = dulieu;
        }
        private Dictionary<string, List<string>> nganh;
        private Dictionary<string, List<string>> khoi;
        private void InitializeData()
        {
            nganh = new Dictionary<string, List<string>>
            {
                {
                    "Chương trình chuẩn", new List<string>
                    {
                        "7340116 - Bất động sản",
                        "7340205 - Công nghệ tài chính",
                        "7340405 - Hệ thống thông tin quản lý",
                        "7340301 - Kế toán",
                        "7340120 - Kinh doanh quốc tế",
                        "7310101 - Kinh tế",
                        "7380107 - Luật kinh tế",
                        "7340115 - Marketing",
                        "7220201 - Ngôn ngữ Anh",
                        "7340101 - Quản trị kinh doanh",
                        "7340201 - Tài chính - Ngân hàng",
                        "7310108 - Toán kinh tế",

                    }
                },
                {
                    "Chương trình đặc thù", new List<string>
                    {

                        "7810201_DT - Quản trị khách sạn",
                        "7810202_DT - Quản trị nhà hàng và dịch vụ ăn uống",
                        "7810103_DT - Quản trị dịch vụ du lịch và lữ hành"
                    }
                },
                {
                    "Chương trình tiếng anh toàn phần", new List<string>()
                    {
                        "7340120_TATP - Kinh doanh quốc tế",
                        "7340115_TATP - Marketing",
                        "7340101_TATP - Quản trị kinh doanh"
                    }
                },
                {
                    "Chương trình tích hợp", new List<string>()
                    {
                        "7340301_TH - Kế toán",
                        "7340120_TH - Kinh doanh quốc tế",
                        "7340115_TH - Marketing" ,
                        "7340101_TH - Quản trị kinh doanh",
                        "7340201_TH - Tài chính - Ngân hàng"
                    }
                },

            };
            // Nhóm khối thi chung
            List<string> khoithi1 = new List<string>
            {
                "A00 (Toán, Vật lý, Hóa học)",
                "A01 (Toán, Vật lý, Tiếng Anh)",
                "D01 (Toán, Ngữ văn, Tiếng Anh)",
                "D96 (Toán, Tiếng Anh, Khoa học xã hội)"
            };

            List<string> khoithi2 = new List<string>
            {
                "D01 (Toán, Ngữ văn, Tiếng Anh)",
                "D96 (Toán, Tiếng Anh, Khoa học xã hội)",
                "D72 (Ngữ văn, Tiếng Anh, Khoa học tự nhiên)",
                "D78 (Ngữ văn, Tiếng Anh, Khoa học xã hội)"
            };

            // lưu trữ ngành và khối xét tuyển tương ứng
            khoi = new Dictionary<string, List<string>>();

            // Các ngành xét tuyển chung khối
            foreach (var major in new List<string>
            {
                "7340116 - Bất động sản",
                "7340205 - Công nghệ tài chính",
                "7340405 - Hệ thống thông tin quản lý",
                "7340301 - Kế toán",
                "7340120 - Kinh doanh quốc tế",
                "7310101 - Kinh tế",
                "7380107 - Luật kinh tế",
                "7340115 - Marketing",
                "7340101 - Quản trị kinh doanh",
                "7340201 - Tài chính - Ngân hàng",
                "7310108 - Toán kinh tế",
                "7340301_TH - Kế toán",
                "7340120_TH - Kinh doanh quốc tế",
                "7340115_TH - Marketing" ,
                "7340101_TH - Quản trị kinh doanh",
                "7340201_TH - Tài chính - Ngân hàng",
                "7340120_TATP - Kinh doanh quốc tế",
                "7340115_TATP - Marketing",
                "7340101_TATP - Quản trị kinh doanh"
            })
            {
                khoi[major] = new List<string>(khoithi1);
            }
            foreach (var major in new List<string>
            {
                "7220201 - Ngôn ngữ Anh",
                "7810201_DT - Quản trị khách sạn",
                "7810202_DT - Quản trị nhà hàng và dịch vụ ăn uống",
                "7810103_DT - Quản trị dịch vụ du lịch và lữ hành"
            })
            {
                khoi[major] = new List<string>(khoithi2);
            }



            cboctrdt.Items.AddRange(nganh.Keys.ToArray());
        }

        private void cboctrdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbonganh.Items.Clear();

            string selectedProgram = cboctrdt.SelectedItem.ToString();

            if (nganh.ContainsKey(selectedProgram))
            {
                cbonganh.Items.AddRange(nganh[selectedProgram].ToArray());
            }
        }

        private void cbonganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbotohop.Items.Clear();

            string selectedMajor = cbonganh.SelectedItem.ToString();

            if (khoi.ContainsKey(selectedMajor))
            {
                cbotohop.Items.AddRange(khoi[selectedMajor].ToArray());
            }
        }

        private void cbotohop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPhuongthuc3_Load(object sender, EventArgs e)
        {
            cboctrdt.SelectedIndexChanged += cboctrdt_SelectedIndexChanged;
            cbonganh.SelectedIndexChanged += cbonganh_SelectedIndexChanged;
        }

        private void btnXD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboctrdt.Text))
            {
                MessageBox.Show("Bạn chưa chọn chương trình đào tạo. Vui lòng chọn chương trình đào tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbonganh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngành. Vui lòng chọn ngành! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nganh = cbonganh.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(cbotohop.Text))
            {
                MessageBox.Show("Bạn chưa chọn khối xét tuyển. Vui lòng chọn khối xét tuyển!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedKhoi = cbotohop.SelectedItem.ToString();


            if (string.IsNullOrWhiteSpace(cboctrdt.Text))
            {
                MessageBox.Show("Bạn chưa chọn khối xét tuyển. Vui lòng chọn khối xét tuyển!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nganh == "7220201 - Ngôn ngữ Anh")
            {
                if (selectedKhoi == "D01 (Toán, Ngữ văn, Tiếng Anh)")
                {
                    lblxemdiem.Text = dulieu.NNAD01.ToString("N2");

                }
                else if (selectedKhoi == "D72 (Ngữ văn, Tiếng Anh, Khoa học tự nhiên)")
                {
                    lblxemdiem.Text = dulieu.NNAD72.ToString("N2");

                }
                else if (selectedKhoi == "D78 (Ngữ văn, Tiếng Anh, Khoa học xã hội)")
                {
                    lblxemdiem.Text = dulieu.NNAD78.ToString("N2");

                }
                else if (selectedKhoi == "D96 (Toán, Tiếng Anh, Khoa học xã hội)")
                {
                    lblxemdiem.Text = dulieu.NNAD96.ToString("N2");

                }


            }

            else
            {
                if (selectedKhoi == "A00 (Toán, Vật lý, Hóa học)")
                {
                    lblxemdiem.Text = dulieu.DTA00.ToString("N2");
                }
                else if (selectedKhoi == "A01 (Toán, Vật lý, Tiếng Anh)")
                {
                    lblxemdiem.Text = dulieu.DTA01.ToString("N2");
                }
                else if (selectedKhoi == "D01 (Toán, Ngữ văn, Tiếng Anh)")
                {
                    lblxemdiem.Text = dulieu.DTD01.ToString("N2");

                }
                else if (selectedKhoi == "D72 (Ngữ văn, Tiếng Anh, Khoa học tự nhiên)")
                {
                    lblxemdiem.Text = dulieu.DTD72.ToString("N2");

                }
                else if (selectedKhoi == "D78 (Ngữ văn, Tiếng Anh, Khoa học xã hội)")
                {
                    lblxemdiem.Text = dulieu.DTD78.ToString("N2");

                }
                else if (selectedKhoi == "D96 (Toán, Tiếng Anh, Khoa học xã hội)")
                {
                    lblxemdiem.Text = dulieu.DTD96.ToString("N2");

                }
            }



        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmChonPhuongThucXT frm = new frmChonPhuongThucXT(dulieu);
            frm.ShowDialog();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            frmChonPhuongThucXT fr = new frmChonPhuongThucXT(dulieu);
            this.Hide();
            fr.ShowDialog();

        }

        private void frmPhuongthuc3_FormClosed(object sender, FormClosedEventArgs e)
        {
          Application.Exit();

        }
    }
}
