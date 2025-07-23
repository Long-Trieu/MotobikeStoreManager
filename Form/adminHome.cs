using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXM_8
{
    public partial class adminHome :DevComponents.DotNetBar.Office2007RibbonForm
    {
        public adminHome()
        {
            InitializeComponent();
        }

        public int chuchay = 10;

        // Kiểm tra sự tồn tại của form trước khi gọi 
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        // End Kiểm tra sự tồn tại của form.

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ChangePassword") == false)
            {
                ChangePassword changePassword = new ChangePassword();
                changePassword.MdiParent = this;
                labelX1.Visible = false;
                changePassword.Show();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn thoát khỏi chương trình?";
            string title = "Close";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void ribbonBar12_ItemClick(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlnhanvien") == false)
            {
                qlnhanvien frmqlnhanvien = new qlnhanvien();
                frmqlnhanvien.MdiParent = this;
                labelX1.Visible = false;
                frmqlnhanvien.Show();
            }
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qltk") == false)
            {
                qltk frmqltk = new qltk();
                frmqltk.MdiParent = this;
                labelX1.Visible = false;
                frmqltk.Show();
            }
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkkhach") == false)
            {
                tkkhach frmtimkiemkhach = new tkkhach();
                frmtimkiemkhach.MdiParent = this;
                labelX1.Visible = false;
                frmtimkiemkhach.Show();
            }
        }

        private void buttonItem50_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkxe") == false)
            {
                tkxe frmttkxe = new tkxe();
                frmttkxe.MdiParent = this;
                labelX1.Visible = false;
                frmttkxe.Show();
            }
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkncc") == false)
            {
                tkncc frmtkncc = new tkncc();
                frmtkncc.MdiParent = this;
                labelX1.Visible = false;
                frmtkncc.Show();
            }
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkhoadontt") == false)
            {
                tkhoadontt frmtkhdtt = new tkhoadontt();
                frmtkhdtt.MdiParent = this;
                labelX1.Visible = false;
                frmtkhdtt.Show();
            }
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkhoadonbanhang") == false)
            {
                tkhoadonbanhang frmtkhdbanhang = new tkhoadonbanhang();
                frmtkhdbanhang.MdiParent = this;
                labelX1.Visible = false;
                frmtkhdbanhang.Show();
            }
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkphieunhap") == false)
            {
                tkphieunhap frmtkphieunhap = new tkphieunhap();
                frmtkphieunhap.MdiParent = this;
                labelX1.Visible = false;
                frmtkphieunhap.Show();
            }
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tknhanvien") == false)
            {
                tknhanvien frmtknhanvien = new tknhanvien();
                frmtknhanvien.MdiParent = this;
                labelX1.Visible = false;
                frmtknhanvien.Show();
            }
        }



        private void buttonItem19_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("RPKhachhang") == false)
            {
                RPKhachhang frmrpkhachhang = new RPKhachhang();
                frmrpkhachhang.MdiParent = this;
                labelX1.Visible = false;
                frmrpkhachhang.Show();
            }
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("RPBanhang") == false)
            {
                RPBanhang frmrpbanhang = new RPBanhang();
                frmrpbanhang.MdiParent = this;
                labelX1.Visible = false;
                frmrpbanhang.Show();
            }
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("RPNhaphang") == false)
            {
                RPNhaphang nhaphangrp = new RPNhaphang();
                nhaphangrp.MdiParent = this;
                labelX1.Visible = false;
                nhaphangrp.Show();
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("about") == false)
            {
                about frmabout = new about();
                frmabout.MdiParent = this;
                labelX1.Visible = false;
                frmabout.Show();
            }
        }
    }
}
