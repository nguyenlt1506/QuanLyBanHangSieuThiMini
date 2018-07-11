using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using QuanLyBanHangSieuThiMini.Objects;

namespace QuanLyBanHangSieuThiMini.Models
{
    class NhanVienMod
    {
        string cnn = ConfigurationManager.ConnectionStrings["Quanlysieuthi"].ToString();

        public bool User(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_getDataByUserAndPass";
                cn.Open();
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@username", username);
                    cm.Parameters.AddWithValue("@password", password);
                    try
                    {
                        SqlDataReader dr;
                        dr = cm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            return true;
                        } 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                return false;
            }
            
        }

        public DataTable GetData()
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhanVien_getData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetDataByUser(string username)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                DataTable dt = new DataTable();
                string query = "sp_tblNhanVien_getDataByUser";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@username", username);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return dt;
            }
        }

        public bool UpdatePass(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_updatePass";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@username", username);
                        cm.Parameters.AddWithValue("@password", password);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return false;
        }

        public bool InsertData(NhanVien nvObj)
        {
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "sp_tblNhanVien_inserData";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@hoten", nvObj.Hoten);
                        cm.Parameters.AddWithValue("@ngaysinh", nvObj.Ngaysinh);
                        cm.Parameters.AddWithValue("@gioitinh", nvObj.Gioitinh);
                        cm.Parameters.AddWithValue("@sdt", nvObj.Sdt);
                        cm.Parameters.AddWithValue("@email", nvObj.Email);
                        cm.Parameters.AddWithValue("@diachi", nvObj.Diachi);
                        cm.Parameters.AddWithValue("@user", nvObj.Username);
                        cm.Parameters.AddWithValue("@pass", nvObj.Password);
                        cm.Parameters.AddWithValue("@quyen", nvObj.Quyen);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return false;
        }
    }
}
