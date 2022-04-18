using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formquanlycacnhasanxuat
{
    public partial class frprintnhanvien : Form
    {
        string str = @"Data Source=DESKTOP-4J7QUR2\SQLEXPRESS;Initial Catalog=QLCuaHangDienThoai;Integrated Security=True";
        ReportDocument rpt = new ReportDocument();
        public frprintnhanvien()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn=new SqlConnection(str))
            {
                SqlDataAdapter sda = new SqlDataAdapter(
                    "SELECT * FROM dbo.tblNhanVien WHERE FLOOR(DATEDIFF(DAY,  dNgaysinh,dNgayvaolam) / 365.25)="+int.Parse(textBox.Text), conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                printnhanvien cr1 = new printnhanvien();
                cr1.SetDataSource(dt);
                report.ReportSource = cr1;
                report.Refresh();
            }
        }
        private void frprintnhanvien_Load(object sender, EventArgs e)
        {
            rpt.Load(@"G:\Csharpdocument\Formquanlycacnhasanxuat\printnhanvien.rpt");
            report.ReportSource = rpt;
            report.Refresh();
        }
    }
}
