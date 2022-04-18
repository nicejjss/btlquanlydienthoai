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
using static Formquanlycacnhasanxuat.quyennguoidung;

namespace Formquanlycacnhasanxuat
{
    public partial class dangnhap : Form
    {
        string str = @"Data Source=DESKTOP-4J7QUR2\SQLEXPRESS;Initial Catalog=QLCuaHangDienThoai;Integrated Security=True";
        public dangnhap()
        {
            InitializeComponent();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(str);
            //SqlDataAdapter sda = new SqlDataAdapter("dangnhap", conn);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sda.SelectCommand.Parameters.AddWithValue("@tentaikhoan", txttaikhoan.Text);
            //sda.SelectCommand.Parameters.AddWithValue("@matkhau", txtmatkhau.Text);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //         quyennguoidung.quyen =dr["Quyen"].ToString();
            //    }
                this.Hide();
                frnhacungcap f = new frnhacungcap();
                f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Tài Khoản hoặc mật khẩu chưa đúng");
            //}
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban Muon Thoat Khong", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void cbhienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbhienmatkhau.Checked==true)
                txtmatkhau.PasswordChar='\0';
            if(cbhienmatkhau.Checked == false)
                txtmatkhau.PasswordChar = '*';
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
