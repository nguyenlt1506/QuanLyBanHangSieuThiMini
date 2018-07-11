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
    public partial class frmSuaLoaiHang : Form
    {
        QuanLyMatHangCtrl qlmh = new QuanLyMatHangCtrl();
        LoaiHang loaihangObj = new LoaiHang();

        public frmSuaLoaiHang(LoaiHang loaihangObj)
        {
            InitializeComponent();
            this.loaihangObj = loaihangObj;
            txtTenloaihang.Text = loaihangObj.Tenloaihang;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GanDuLieu()
        {
            loaihangObj.Tenloaihang = txtTenloaihang.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            if (txtTenloaihang.Text != "")
            {
                if (qlmh.UpdateData(loaihangObj))
                {
                    MessageBox.Show("Sửa thông tin thành công");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
    }
}
