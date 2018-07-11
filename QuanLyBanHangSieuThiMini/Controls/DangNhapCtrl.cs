using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangSieuThiMini.Models;
using System.Data;

namespace QuanLyBanHangSieuThiMini.Controls
{
    class DangNhapCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public bool User(string username, string password)
        {
            return nvMod.User(username, password);
        }

        public DataTable GetDataByUser(string username)
        {
            return nvMod.GetDataByUser(username);
        }

        public bool UpdatePass(string username, string password)
        {
            return nvMod.UpdatePass(username, password);
        }
    }

    public static class LoginInfo
    {
        public static string UserName;
    }
}
