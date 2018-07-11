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

namespace QuanLyBanHangSieuThiMini.Forms.NhanVien
{
    public partial class frmChangePass : Form
    {
        DangNhapCtrl dangnhap = new DangNhapCtrl();
        public frmChangePass()
        {
            InitializeComponent();
            txtUsername.Text = LoginInfo.UserName;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string user = LoginInfo.UserName;
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string passConfirm = txtPassConfirm.Text;

            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtPassConfirm.Text == "")
            {
                MessageBox.Show("Thông tin cần được nhập đầy đủ");
                return;
            } else if(oldPass == newPass) {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ");
            }
            else
            {
                if (dangnhap.User(user, oldPass))
                {
                    if (newPass == passConfirm)
                    {
                        dangnhap.UpdatePass(user, passConfirm);
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp nhau");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
            
        }
    }
}
