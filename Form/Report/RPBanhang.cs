using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QLXM_8
{
    public partial class RPBanhang : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public RPBanhang()
        {
            InitializeComponent();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Application.StartupPath + @"\Report\BH_Full.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày lập!", "Lỗi");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(Application.StartupPath + @"\Report\BH_Ngay.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = txt_diachi.Text;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["NgayLap"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhóm xe!", "Lỗi");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(Application.StartupPath + @"\Report\BH_NhomXe.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = txt_diachi.Text;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["MaNX"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }    
        }
    }
}
