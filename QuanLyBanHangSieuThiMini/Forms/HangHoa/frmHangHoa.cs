using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangSieuThiMini.Forms.Hàng_hóa;
using QuanLyBanHangSieuThiMini.Controls;
using QuanLyBanHangSieuThiMini.Objects;

namespace QuanLyBanHangSieuThiMini.Forms
{
    public partial class frmHangHoa : Form
    {
        QuanLyMatHangCtrl qlmh = new QuanLyMatHangCtrl();
        LoaiHang loaihangObj = new LoaiHang();

        public frmHangHoa()
        {
            InitializeComponent();
            LoadLoaiHang();
        }

        private void LoadLoaiHang()
        {
            DataTable dt = qlmh.GetData();
            dgvLoaiHang.DataSource = dt;
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            frmThemHangHoa formThemHang = new frmThemHangHoa();
            formThemHang.ShowDialog(this);
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang frmThemloaihang = new frmThemLoaiHang();
            frmThemloaihang.ShowDialog();
            LoadLoaiHang();
        }

        public void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            string tenloai, maloai;
            tenloai = dgvLoaiHang.CurrentRow.Cells[1].Value.ToString();
            maloai = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();

            loaihangObj.Maloaihang = maloai;
            loaihangObj.Tenloaihang = tenloai;
            
            frmSuaLoaiHang frmSualoaihang = new frmSuaLoaiHang(loaihangObj);
            frmSualoaihang.ShowDialog();
            LoadLoaiHang();
        }

    }
}
