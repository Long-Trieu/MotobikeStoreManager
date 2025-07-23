using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXM_8
{
    public partial class ChangePassword : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        //#region "Biến cục bộ trong form"
        //private OleDbConnection objConnect;
        //private DataTable objDataTable;
        //private DataTable objDataTable1;
        //#endregion
        //#region "Tạo và hủy kết nối với database"
        //private void ketnoidata()
        //{
        //    String chuoikn = "Provider=Microsoft.ACE.OLEDB.12.0 ;" +
        //                    "Data Source =" + Application.StartupPath + @"\qlxm.mdb;";
        //    objConnect = new OleDbConnection(chuoikn);
        //    objConnect.Open(); // Mở kết nối
        //}
        //private void huyketnoidata()
        //{
        //    objConnect.Close(); // Đóng kết nối
        //    objConnect.Dispose(); // Giải phóng tài nguyên
        //    objConnect = null; // Hủy đối tượng
        //}

        //#endregion


        //public bool CheckInfor(string pass)
        //{
        //    String chuoikn = "Provider=Microsoft.ACE.OLEDB.12.0;" +
        //                    "Data Source =" + Application.StartupPath + @"\qlxm.mdb;";
        //    objConnect = new OleDbConnection(chuoikn);
        //    // Tạo Command
        //    OleDbCommand cmd = new OleDbCommand("select * from Dang_Nhap where PassWord='" + pass + "'", objConnect);
        //    objConnect.Open(); // Mở kết nối
        //    OleDbDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        objConnect.Close();
        //        return true;
        //    }
        //    objConnect.Close();
        //    return false;
        //}


        //#region "Update dữ liệu"
        //// Update dữ liệu trực tiếp có tham số
        //// Tạo kết nối với file access
        //private void update_dulieu()
        //{
        //    // Tạo kết nối Access
        //    ketnoidata();
        //    // Tạo đối tượng Command
        //    OleDbCommand objCommand = new OleDbCommand();
        //    objCommand.Connection = objConnect;
        //    objCommand.CommandType = CommandType.Text;
        //    objCommand.CommandText = "Update Dang_Nhap " +
        //                             "Set UserName=@UserName, PassWord=@PassWord" +
        //                             "Where STT=@STT";
        //    if (txt_oldpass.Text != txt_txt_confignp.Text)
        //    {
        //        MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Lỗi");
        //        return;
        //    }
        //    objCommand.Parameters.Add("@UserName", OleDbType.VarChar).Value = txt_username.Text;
        //    objCommand.Parameters.Add("@PassWord", OleDbType.VarChar).Value = txt_oldpass.Text;
        //    objCommand.ExecuteNonQuery();
        //    //Hủy đối tượng
        //    objCommand.Dispose();
        //    objCommand = null;
        //    // Đóng kết nối
        //    huyketnoidata();
        //}
        //#endregion

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_sua_Click(object sender, EventArgs e)
        {
            if (txt_newPass.Text == txt_confignp.Text)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Nhập mật khẩu không trùng khớp!", "Lỗi");
            }    
        }

        private void txt_oldpass_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txt_oldpass.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txt_oldpass.MaxLength = 15;
        }

        private void txt_newPass_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txt_newPass.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txt_newPass.MaxLength = 15;
        }

        private void txt_confignp_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txt_confignp.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txt_confignp.MaxLength = 15;
        }

        //private void cmd_sua_Click(object sender, EventArgs e)
        //{
        //    update_dulieu();
        //}
    }
}
