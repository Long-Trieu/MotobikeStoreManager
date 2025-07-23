
namespace QLXM_8
{
    partial class ChangePassword
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_confignp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_oldpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_newPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmd_thoat = new DevComponents.DotNetBar.ButtonX();
            this.cmd_sua = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_confignp);
            this.groupPanel1.Controls.Add(this.txt_oldpass);
            this.groupPanel1.Controls.Add(this.txt_newPass);
            this.groupPanel1.Controls.Add(this.cmd_thoat);
            this.groupPanel1.Controls.Add(this.cmd_sua);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(17, 14);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(492, 277);
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
            this.groupPanel1.Text = "Đổi mật khẩu";
            // 
            // txt_confignp
            // 
            // 
            // 
            // 
            this.txt_confignp.Border.Class = "TextBoxBorder";
            this.txt_confignp.Location = new System.Drawing.Point(267, 137);
            this.txt_confignp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confignp.Name = "txt_confignp";
            this.txt_confignp.Size = new System.Drawing.Size(133, 22);
            this.txt_confignp.TabIndex = 4;
            this.txt_confignp.TextChanged += new System.EventHandler(this.txt_confignp_TextChanged);
            // 
            // txt_oldpass
            // 
            // 
            // 
            // 
            this.txt_oldpass.Border.Class = "TextBoxBorder";
            this.txt_oldpass.Location = new System.Drawing.Point(267, 30);
            this.txt_oldpass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Size = new System.Drawing.Size(133, 22);
            this.txt_oldpass.TabIndex = 4;
            this.txt_oldpass.TextChanged += new System.EventHandler(this.txt_oldpass_TextChanged);
            // 
            // txt_newPass
            // 
            // 
            // 
            // 
            this.txt_newPass.Border.Class = "TextBoxBorder";
            this.txt_newPass.Location = new System.Drawing.Point(267, 82);
            this.txt_newPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(133, 22);
            this.txt_newPass.TabIndex = 4;
            this.txt_newPass.TextChanged += new System.EventHandler(this.txt_newPass_TextChanged);
            // 
            // cmd_thoat
            // 
            this.cmd_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_thoat.Location = new System.Drawing.Point(334, 204);
            this.cmd_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_thoat.Name = "cmd_thoat";
            this.cmd_thoat.Size = new System.Drawing.Size(100, 28);
            this.cmd_thoat.TabIndex = 3;
            this.cmd_thoat.Text = "Thoát";
            this.cmd_thoat.Click += new System.EventHandler(this.cmd_thoat_Click);
            // 
            // cmd_sua
            // 
            this.cmd_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmd_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmd_sua.Location = new System.Drawing.Point(51, 204);
            this.cmd_sua.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_sua.Name = "cmd_sua";
            this.cmd_sua.Size = new System.Drawing.Size(100, 28);
            this.cmd_sua.TabIndex = 3;
            this.cmd_sua.Text = "Thay Đổi";
            this.cmd_sua.Click += new System.EventHandler(this.cmd_sua_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(77, 82);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 28);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "New Password";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(77, 131);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(150, 28);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Confirm New Password";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(77, 30);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 28);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Old Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 331);
            this.Controls.Add(this.groupPanel1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_confignp;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_oldpass;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_newPass;
        private DevComponents.DotNetBar.ButtonX cmd_thoat;
        private DevComponents.DotNetBar.ButtonX cmd_sua;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}