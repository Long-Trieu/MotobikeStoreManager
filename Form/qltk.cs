using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXM_8
{
    public partial class qltk : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qltk()
        {
            InitializeComponent();
        }

        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        // private DataTable objDataTable1;
        #endregion
        #region "Tạo và hủy kết nối với database"
        private void ketnoidata()
        {
            String chuoikn = "Provider=Microsoft.ACE.OLEDB.12.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\qlxm.mdb;";
            objConnect = new OleDbConnection(chuoikn);
            objConnect.Open(); // Mở kết nối
        }
        private void huyketnoidata()
        {
            objConnect.Close(); // Đóng kết nối
            objConnect.Dispose(); // Giải phóng tài nguyên
            objConnect = null; // Hủy đối tượng
        }
        #endregion
        #region "Select dữ liệu"
        private void hiendulieu()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Dang_Nhap ORDER BY STT";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter = new OleDbDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            Grid1.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối
            huyketnoidata();
        }
        #endregion
        #region " Binding dữ liệu"
        private void bindingdata()
        {
            txt_username.DataBindings.Clear();
            txt_username.DataBindings.Add("Text", Grid1.DataSource, "UserName"); //1
            txt_pass.DataBindings.Clear();
            txt_pass.DataBindings.Add("Text", Grid1.DataSource, "PassWord"); //2
            txt_quyen.DataBindings.Clear();
            txt_quyen.DataBindings.Add("Text", Grid1.DataSource, "Quyen"); //3
            txt_stt.DataBindings.Clear();
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT"); //4
        }
        #endregion
        #region "Insert dữ liệu bằng adapter"
        private void InsertByAdapter()
        {
            // Tạo kết nối CSDL
            ketnoidata();
            // Nạp dữ liệu vào DataTable
            objDataTable = new DataTable("cde");
            // Tạo đối tượng Adapter và Fill vào DataTable
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Dang_Nhap", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["UserName"] = txt_username.Text;
            objRow["PassWord"] = txt_pass.Text;
            objRow["Quyen"] = txt_quyen.Text;
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Dang_Nhap values(@STT, @UserName, @PassWord, @Quyen)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@UserName", OleDbType.VarChar, 30, "UserName");
            objCommand.Parameters.Add("@PassWord", OleDbType.VarChar, 30, "PassWord");
            objCommand.Parameters.Add("@Quyen", OleDbType.VarChar, 30, "Quyen");
            // Insert dữ liệu vào nguồn
            objAdapter.InsertCommand = objCommand;
            objAdapter.Update(objDataTable);
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            huyketnoidata();
        }
        #endregion
        #region "Update dữ liệu"
        // Update dữ liệu trực tiếp có tham số
        // Tạo kết nối với file access
        private void update_dulieu()
        {
            // Tạo kết nối Access
            ketnoidata();
            // Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update Dang_Nhap " +
                                     "Set UserName=@UserName, PassWord=@PassWord, Quyen=@Quyen " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DangNhap Set UserName=?,PassWord=?,Quyen=? Where STT=?";
            objCommand.Parameters.Add("@UserName", OleDbType.VarChar, 30, "UserName").Value = txt_username.Text;
            objCommand.Parameters.Add("@PassWord", OleDbType.VarChar, 30, "PassWord").Value = txt_pass.Text;
            objCommand.Parameters.Add("@Quyen", OleDbType.VarChar, 30, "Quyen").Value = txt_quyen.Text;
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            // Đóng kết nối
            huyketnoidata();
        }
        #endregion
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Dang_Nhap", objConnect);
            objDataTable = new DataTable();
            objAdapter.Fill(objDataTable);
            //Xây dựng commandBuilder
            new OleDbCommandBuilder(objAdapter);
            //Delete Record cần delete trong datatable
            DataRow[] objRow = objDataTable.Select("STT=" + Convert.ToInt32(txt_stt.Text));
            objRow[0].Delete();
            //Delete dữ liệu nguồn
            objAdapter.Update(objDataTable);
            //Hủy đối tượng
            objAdapter.Dispose(); objAdapter = null;
            objDataTable.Dispose(); objDataTable = null;
            huyketnoidata();
        }
        #endregion


        private void cmd_them_Click(object sender, EventArgs e)
        {
            InsertByAdapter();
            hiendulieu();
            bindingdata();
        }

        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            deletedata();
            hiendulieu();
            bindingdata();
        }

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_sua_Click(object sender, EventArgs e)
        {
            update_dulieu();
            hiendulieu();
            bindingdata();
        }

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_pass.Text = "";
            txt_quyen.Text = "";
            txt_stt.Text = "";
        }

        private void qltk_Load(object sender, EventArgs e)
        {
            hiendulieu();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 60;
            Grid1.Columns["UserName"].Width = 130;
            Grid1.Columns["PassWord"].Width = 130;
            Grid1.Columns["Quyen"].Width = 130;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Username";
            Grid1.Columns[2].HeaderText = "Password";
            Grid1.Columns[3].HeaderText = "Quyền";
            #endregion
            bindingdata();

        }
    }
}
