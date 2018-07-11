using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangSieuThiMini.Forms;
using QuanLyBanHangSieuThiMini.Controls;

namespace QuanLyBanHangSieuThiMini
{
    public partial class frmLogin : Form
    {
        DangNhapCtrl dangnhap = new DangNhapCtrl();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (dangnhap.User(username, password))
            {
                LoginInfo.UserName = txtUserName.Text;
                frmMain frmMain = new frmMain();
                frmMain.Show();
                frmMain.Logout += frmMain_Logout;
                this.Hide();
            }
            else
            {
                MessageBox.Show("sai tên tài khoản hoặc mật khẩu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Checking Export or Exit ?
        private void frmMain_Logout(object sender, EventArgs e)
        {
            (sender as frmMain).isShowing = false;
            (sender as frmMain).Close();
            this.Show();
        }

        // Cancel -> Exit App
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
