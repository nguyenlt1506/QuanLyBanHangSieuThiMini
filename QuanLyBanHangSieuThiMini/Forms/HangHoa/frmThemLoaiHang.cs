using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangSieuThiMini.Controls;
using QuanLyBanHangSieuThiMini.Objects;

namespace QuanLyBanHangSieuThiMini.Forms.Hàng_hóa
{
    public partial class frmThemLoaiHang : Form
    {
        QuanLyMatHangCtrl qlmh = new QuanLyMatHangCtrl();

        LoaiHang loaihangObj = new LoaiHang();

        public frmThemLoaiHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GanDuLieu()
        {
            loaihangObj.Maloaihang = "";
            loaihangObj.Tenloaihang = txtTenloaihang.Text.Trim();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            if (txtTenloaihang.Text == "")
            {
                MessageBox.Show("Cần nhập đủ thông tin");
            }
            else
            {
                if (qlmh.InsertData(loaihangObj))
                {
                    MessageBox.Show("Thêm mặt hàng thành công");
                    this.Close();
                }
            }
        }
    }
}
