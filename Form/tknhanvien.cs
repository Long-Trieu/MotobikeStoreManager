using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLXM_8
{
    public partial class tknhanvien : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public tknhanvien()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        //  private DataTable objDataTable1;
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
        #region "Tìm kiếm dữ liệu dữ liệu"
        private void hiendulieu_timkiem_ma() // Tìm kiếm dữ liệu theo mã
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Nhan_Vien Where MaNV LIKE '%" + txt_manv.Text + "%' ORDER BY STT";
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
        private void hiendulieu_timkiem_ten_diachi() // Tìm kiếm dữ liệu theo tên và địa chỉ
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Nhan_Vien Where (HoTenNV LIKE '%" + txt_hoten.Text.ToString().Trim() + "%' AND DiaChi LIKE '%" + txt_diachi.Text.ToString().Trim() + "%')  ORDER BY STT";
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


        private void buttonX1_Click(object sender, EventArgs e)
        {
            hiendulieu_timkiem_ma();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 40;
            Grid1.Columns["MaNV"].Width = 100;
            Grid1.Columns["HoTenNV"].Width = 110;
            Grid1.Columns["CCCD"].Width = 80;
            Grid1.Columns["DiaChi"].Width = 130;
            Grid1.Columns["ChuyenMon"].Width = 110;
            Grid1.Columns["Luong"].Width = 100;

            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[2].HeaderText = "Họ và Tên";
            Grid1.Columns[3].HeaderText = "CCCD";
            Grid1.Columns[4].HeaderText = "Địa Chỉ";
            Grid1.Columns[5].HeaderText = "Chuyên Môn";
            Grid1.Columns[6].HeaderText = "Lương";
            #endregion
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            hiendulieu_timkiem_ten_diachi();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 40;
            Grid1.Columns["MaNV"].Width = 100;
            Grid1.Columns["HoTenNV"].Width = 110;
            Grid1.Columns["CCCD"].Width = 80;
            Grid1.Columns["DiaChi"].Width = 130;
            Grid1.Columns["ChuyenMon"].Width = 110;
            Grid1.Columns["Luong"].Width = 100;

            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[2].HeaderText = "Họ và Tên";
            Grid1.Columns[3].HeaderText = "CCCD";
            Grid1.Columns[4].HeaderText = "Địa Chỉ";
            Grid1.Columns[5].HeaderText = "Chuyên Môn";
            Grid1.Columns[6].HeaderText = "Lương";
            #endregion
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}