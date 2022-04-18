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
    public partial class frnhacungcap : Basemenuform
    {

        //string quyen;
        public frnhacungcap()
        {
            InitializeComponent();
        }
        //public frnhacungcap(string quyen)
        //{
        //    InitializeComponent();
        //    this.quyen = quyen;
        //}
        string str = @"Data Source=DESKTOP-4J7QUR2\SQLEXPRESS;Initial Catalog=QLCuaHangDienThoai;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            hiennhacungcap();
        }
        public void hiennhacungcap()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter(@"Select * from tblnhacungcap", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datanhacc.DataSource = dt;
        }
        private void txtma_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mã nhà cung cấp không được sửa \n tự động cấp phát khi thêm mới ");
        }
        private void datanhacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtma.Text = datanhacc.Rows[i].Cells[0].Value.ToString();
                txtten.Text = datanhacc.Rows[i].Cells[1].Value.ToString();
                txtdiachi.Text = datanhacc.Rows[i].Cells[2].Value.ToString();
                txtsdt.Text = datanhacc.Rows[i].Cells[3].Value.ToString();
            }
        }
        //Sua nha cung cap
        private void btnsua_Click(object sender, EventArgs e)
        {
            //if (quyennguoidung.quyen == "admin") {
                if (txtma.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtten.Text == "")
                {
                    MessageBox.Show("Các trường chưa được thêm đầy đủ");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Ban muon sua nha cung cap nay", "Thong bao", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("suanhacungcap", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Sua thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Sua that bai");
                        }
                        hiennhacungcap();
                        conn.Close();
                    }
                }
            //}
            //else
            //{
            //    MessageBox.Show("ADMIN mới có quyền chỉnh sửa!!!");
            //}
          
        }
        //Them nha cung cap
        private void btnthem_Click(object sender, EventArgs e)
        {
            //if (quyennguoidung.quyen == "admin") {
                if (txtdiachi.Text == "" || txtsdt.Text == "" || txtten.Text == "")
                {
                    MessageBox.Show("Các trường chưa được thêm đầy đủ");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Ban muon them nha cung cap nay", "Thong bao", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("themnhacungcap", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                        cmd.Parameters.AddWithValue("@sodienthoai", txtsdt.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Them thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Them that bai");
                        }
                        hiennhacungcap();
                        conn.Close();
                    }
                }
            //}
            //else
            //{
            //    MessageBox.Show("ADMIN mới có quyền chỉnh sửa!!!");
            //}
               
        }
        //Xoa nha cung cap
        private void btnxoa_Click(object sender, EventArgs e)
        {
            //if (quyennguoidung.quyen == "admin") {
                if (txtma.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtten.Text == "")
                {
                    MessageBox.Show("Các trường chưa được thêm đầy đủ");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Ban muon xoa nha cung cap nay", "Thong bao", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("xoanhacungcap", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Mancc", txtma.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Xoa thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Xoa that bai");
                        }
                        hiennhacungcap();
                        conn.Close();
                    }
                }
            //}
            //else
            //{
            //    MessageBox.Show("ADMIN mới có quyền chỉnh sửa!!!");
            //}
           

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            txtma.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
        }


        private void btntimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(str);
            int i = 0;
            if ((!cbdiachi.Checked) && (!cbsdt.Checked) && (!cbten.Checked))
            {
                MessageBox.Show("Chưa tích chọn tiêu chí để tìm"); i++;
            }
            if (cbdiachi.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("TimNhacungcapcodiachi", sql);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datanhacc.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    i++;
                }

            }
            if (cbten.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("TimNhacungcapcoten", sql);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@ten", txtten.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datanhacc.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    i++;
                }
            }
            if (cbsdt.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("TimNhacungcapcosdt", sql);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@sdt", txtsdt.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datanhacc.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                MessageBox.Show("Không có nhà cung cấp cần tìm.");
            }

        }

        private void btnhientatca_Click(object sender, EventArgs e)
        {
            hiennhacungcap();

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nhàCungCấpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void datanhacc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frnhacungcap_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frnhacungcap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban Muon Thoat Khong", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
