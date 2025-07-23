
namespace QLXM_8
{
    partial class qltk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlxmtk = new QLXM_8.qlxmtk();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmd_nhaplai = new DevComponents.DotNetBar.ButtonX();
            this.cmd_sua = new DevComponents.DotNetBar.ButtonX();
            this.cmd_xoa = new DevComponents.DotNetBar.ButtonX();
            this.cmd_thoat = new DevComponents.DotNetBar.ButtonX();
            this.cmd_them = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_stt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_quyen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dang_NhapTableAdapter = new QLXM_8.qlxmtkTableAdapters.Dang_NhapTableAdapter();
            this.Grid1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxmtk)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dangNhapBindingSource
            // 
            this.dangNhapBindingSource.DataMember = "Dang_Nhap";
            this.dangNhapBindingSource.DataSource = this.qlxmtk;
            // 
            // qlxmtk
            // 
            this.qlxmtk.DataSetName = "qlxmtk";
            this.qlxmtk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmd_nhaplai);
            this.groupPanel1.Controls.Add(this.cmd_sua);
            this.groupPanel1.Controls.Add(this.cmd_xoa);
            this.groupPanel1.Controls.Add(this.cmd_thoat);
            this.groupPanel1.Controls.Add(this.cmd_them);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txt_username);
            this.groupPanel1.Controls.Add(this.txt_stt);
            this.groupPanel1.Controls.Add(this.txt_pass);
            this.groupPanel1.Controls.Add(this.txt_quyen);
            this.groupPanel1.Location = new System.Drawing.Point(86, 14);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(733, 269);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Quản Lý Tài Khoản";
            // 
            // cmd_nhaplai
            // 
            this.cmd_nhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_nhaplai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_nhaplai.Location = new System.Drawing.Point(549, 108);
            this.cmd_nhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_nhaplai.Name = "cmd_nhaplai";
            this.cmd_nhaplai.Size = new System.Drawing.Size(100, 28);
            this.cmd_nhaplai.TabIndex = 0;
            this.cmd_nhaplai.Text = "Nhập Lại";
            this.cmd_nhaplai.Click += new System.EventHandler(this.cmd_nhaplai_Click);
            // 
            // cmd_sua
            // 
            this.cmd_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_sua.Location = new System.Drawing.Point(422, 108);
            this.cmd_sua.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_sua.Name = "cmd_sua";
            this.cmd_sua.Size = new System.Drawing.Size(100, 28);
            this.cmd_sua.TabIndex = 0;
            this.cmd_sua.Text = "Sửa";
            this.cmd_sua.Click += new System.EventHandler(this.cmd_sua_Click);
            // 
            // cmd_xoa
            // 
            this.cmd_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_xoa.Location = new System.Drawing.Point(549, 60);
            this.cmd_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_xoa.Name = "cmd_xoa";
            this.cmd_xoa.Size = new System.Drawing.Size(100, 28);
            this.cmd_xoa.TabIndex = 0;
            this.cmd_xoa.Text = "Xóa";
            this.cmd_xoa.Click += new System.EventHandler(this.cmd_xoa_Click);
            // 
            // cmd_thoat
            // 
            this.cmd_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_thoat.Location = new System.Drawing.Point(485, 161);
            this.cmd_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_thoat.Name = "cmd_thoat";
            this.cmd_thoat.Size = new System.Drawing.Size(100, 28);
            this.cmd_thoat.TabIndex = 5;
            this.cmd_thoat.Text = "Thoát";
            this.cmd_thoat.Click += new System.EventHandler(this.cmd_thoat_Click);
            // 
            // cmd_them
            // 
            this.cmd_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_them.Location = new System.Drawing.Point(422, 60);
            this.cmd_them.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_them.Name = "cmd_them";
            this.cmd_them.Size = new System.Drawing.Size(100, 28);
            this.cmd_them.TabIndex = 4;
            this.cmd_them.Text = "Thêm";
            this.cmd_them.Click += new System.EventHandler(this.cmd_them_Click);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(73, 132);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 28);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Password";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(73, 183);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(100, 28);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Quyền";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(73, 82);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 28);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Username";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(73, 34);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 28);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Số Thứ Tự";
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.Border.Class = "TextBoxBorder";
            this.txt_username.Location = new System.Drawing.Point(181, 86);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(161, 22);
            this.txt_username.TabIndex = 1;
            // 
            // txt_stt
            // 
            // 
            // 
            // 
            this.txt_stt.Border.Class = "TextBoxBorder";
            this.txt_stt.Location = new System.Drawing.Point(181, 34);
            this.txt_stt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stt.Name = "txt_stt";
            this.txt_stt.Size = new System.Drawing.Size(161, 22);
            this.txt_stt.TabIndex = 0;
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.Border.Class = "TextBoxBorder";
            this.txt_pass.Location = new System.Drawing.Point(181, 134);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(161, 22);
            this.txt_pass.TabIndex = 0;
            // 
            // txt_quyen
            // 
            // 
            // 
            // 
            this.txt_quyen.Border.Class = "TextBoxBorder";
            this.txt_quyen.Location = new System.Drawing.Point(181, 187);
            this.txt_quyen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quyen.Name = "txt_quyen";
            this.txt_quyen.Size = new System.Drawing.Size(161, 22);
            this.txt_quyen.TabIndex = 0;
            // 
            // dang_NhapTableAdapter
            // 
            this.dang_NhapTableAdapter.ClearBeforeFill = true;
            // 
            // Grid1
            // 
            this.Grid1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Grid1.Location = new System.Drawing.Point(86, 310);
            this.Grid1.Margin = new System.Windows.Forms.Padding(4);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowHeadersWidth = 51;
            this.Grid1.Size = new System.Drawing.Size(733, 185);
            this.Grid1.TabIndex = 6;
            // 
            // qltk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 530);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "qltk";
            this.Text = "qltk";
            this.Load += new System.EventHandler(this.qltk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxmtk)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX cmd_nhaplai;
        private DevComponents.DotNetBar.ButtonX cmd_sua;
        private DevComponents.DotNetBar.ButtonX cmd_xoa;
        private DevComponents.DotNetBar.ButtonX cmd_thoat;
        private DevComponents.DotNetBar.ButtonX cmd_them;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_username;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_stt;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pass;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_quyen;
        private qlxmtk qlxmtk;
        private System.Windows.Forms.BindingSource dangNhapBindingSource;
        private qlxmtkTableAdapters.Dang_NhapTableAdapter dang_NhapTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid1;
    }
}