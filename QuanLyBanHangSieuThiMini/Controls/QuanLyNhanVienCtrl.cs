using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangSieuThiMini.Models;
using QuanLyBanHangSieuThiMini.Objects;
using System.Data;

namespace QuanLyBanHangSieuThiMini.Controls
{
    class QuanLyNhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();

        public DataTable GetData()
        {
            return nvMod.GetData();
        }

        public bool InsertData(NhanVien nvObj)
        {
            return nvMod.InsertData(nvObj);
        }
    }
}
