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

namespace QuanLyBanHangSieuThiMini.Forms
{
    public partial class frmNhanVien : Form
    {
        QuanLyNhanVienCtrl qlnv = new QuanLyNhanVienCtrl();

        public frmNhanVien()
        {
            InitializeComponent();
            DataTable dt = qlnv.GetData();
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.Columns["dNgaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        void GanDuLieu()
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }
    }
}
