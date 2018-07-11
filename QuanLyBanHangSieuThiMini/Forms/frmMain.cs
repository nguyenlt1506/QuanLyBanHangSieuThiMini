using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangSieuThiMini.Forms.ThongKe;
using QuanLyBanHangSieuThiMini.Forms;
using QuanLyBanHangSieuThiMini.Forms.HangHoa;
using QuanLyBanHangSieuThiMini.Forms.NhaCungCap;
using QuanLyBanHangSieuThiMini.Forms.NhanVien;
using QuanLyBanHangSieuThiMini.Controls;

namespace QuanLyBanHangSieuThiMini.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (LoginInfo.UserName != "")
            {
                lblUserName.Text = LoginInfo.UserName;
            }

        }
        frmHangHoa formHangHoa = new frmHangHoa();
        frmNhapHang formNhapHang = new frmNhapHang();
        frmHoaDonNhap formHoaDonNhap = new frmHoaDonNhap();
        frmHoaDonBan formHoaDonBan = new frmHoaDonBan();
        frmBanHang formBanHang = new frmBanHang();
        frmNhanVien formNhanVien = new frmNhanVien();
        frmThongKe formThongKe = new frmThongKe();
        frmHangHong formHangHong = new frmHangHong();
        frmNhaCungCap formNCC = new frmNhaCungCap();
        frmGiamGia formGia = new frmGiamGia();

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActivateChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmHangHoa"))
            {
                formHangHoa.MdiParent = this;
                formHangHoa.Show();
            }
            else
            {
                ActivateChildForm("frmHangHoa");
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNhapHang"))
            {
                formNhapHang.MdiParent = this;
                formNhapHang.Show();
            }
            else
            {
                ActivateChildForm("frmNhapHang");
            }
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            
            formHoaDonNhap.MdiParent = this;
            formHoaDonNhap.Show();
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            
            formHoaDonBan.MdiParent = this;
            formHoaDonBan.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmBanHang"))
            {
                formBanHang.MdiParent = this;
                formBanHang.Show();
            }
            else
            {
                ActivateChildForm("frmBanHang");
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            
            formNhanVien.MdiParent = this;
            formNhanVien.Show();
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            formThongKe.MdiParent = this;
            formThongKe.Show();
        }

        private void btnHangHong_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmHangHong"))
            {
                formHangHong.MdiParent = this;
                formHangHong.Show();
            }
            else
            {
                ActivateChildForm("frmHangHong");
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            
            formNCC.MdiParent = this;
            formNCC.Show();
        }

        private void btnGia_Click(object sender, EventArgs e)
        {
            
            formGia.MdiParent = this;
            formGia.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public bool isShowing = true;
        public event EventHandler Logout;

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isShowing)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dang xuat","dang",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Logout(this, new EventArgs());
            }
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.MdiParent = this;
            frmProfile.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.MdiParent = this;
            frmChangePass.Show();
        }
    }
}
