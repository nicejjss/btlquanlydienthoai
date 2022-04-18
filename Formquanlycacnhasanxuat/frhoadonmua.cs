using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formquanlycacnhasanxuat
{
    public partial class frhoadonmua : Basemenuform
    {
        string quyen;
        public frhoadonmua()
        {
            InitializeComponent();
        }
        public frhoadonmua(string v)
        {
            InitializeComponent();
            this.quyen = v;
        }
        string str = @"Data Source=DESKTOP-4J7QUR2\SQLEXPRESS;Initial Catalog=QLCuaHangDienThoai;Integrated Security=True";
        private void frhoadonmua_Load(object sender, EventArgs e)
        {
           
            hientatca();
        }
        public void hientatca()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter("hienhoadonmua", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datahoadonmua.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
        }

        private void datahoadonmua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            string day = datahoadonmua.Rows[i].Cells[5].Value.ToString();
            if (i >= 0)
            {
                txtmahoadon.Text = datahoadonmua.Rows[i].Cells[0].Value.ToString();
                txtnhanvien.Text = datahoadonmua.Rows[i].Cells[1].Value.ToString();
                txtkhachhang.Text = datahoadonmua.Rows[i].Cells[2].Value.ToString();
                txtdiachi.Text = datahoadonmua.Rows[i].Cells[3].Value.ToString();
                txtsdt.Text = datahoadonmua.Rows[i].Cells[4].Value.ToString();
                txtngaylap.Text = DateTime.Parse(day).ToString();
            }


        }
        private void label10_Click_1(object sender, EventArgs e)
        {

        }
        
        private void btnprint_Click(object sender, EventArgs e)
        {
            thongtindonhang ttdh = new thongtindonhang();
            ttdh.mahoadon = txtmahoadon.Text;
            ttdh.tenkhachhang = txtkhachhang.Text;
            ttdh.tennhanvien = txtnhanvien.Text;
            ttdh.ngaylap = txtngaylap.Text;
            ttdh.diachi = txtdiachi.Text;
            ttdh.sodienthoai = txtsdt.Text;
            printhoadon ph = new printhoadon(ttdh);
            ph.Show();
        }

        private void datahoadonmua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtngaylap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbtenhang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbtenkhachhang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbtennhanvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void btnhientatca_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtmahoadon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
