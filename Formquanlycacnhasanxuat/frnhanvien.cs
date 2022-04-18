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
    public partial class frnhanvien : Basemenuform
    {
        string str = @"Data Source=DESKTOP-4J7QUR2\SQLEXPRESS;Initial Catalog=QLCuaHangDienThoai;Integrated Security=True";
        public frnhanvien()
        {
            InitializeComponent();
        }

        private void frnhanvien_Load(object sender, EventArgs e)
        {
            hientatca();
        }
        public void hientatca()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter("hiennhanvien", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datanhanvien.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            string sex;
            int g = int.Parse(datanhanvien.Rows[i].Cells[2].Value.ToString());
            if (g == 1)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nữ";
            }
            if (i >= 0)
            {
                txtmanhanvien.Text = datanhanvien.Rows[i].Cells[0].Value.ToString();
                txttennhanvien.Text = datanhanvien.Rows[i].Cells[1].Value.ToString();
                txtgioitinh.Text = sex;
                txtdiachi.Text = datanhanvien.Rows[i].Cells[3].Value.ToString();
                txtsdt.Text = datanhanvien.Rows[i].Cells[4].Value.ToString();
                txtngaysinh.Text = datanhanvien.Rows[i].Cells[5].Value.ToString();
                txtngaylam.Text = datanhanvien.Rows[i].Cells[6].Value.ToString();
                txtluong.Text = datanhanvien.Rows[i].Cells[7].Value.ToString();
                txtphucap.Text = datanhanvien.Rows[i].Cells[8].Value.ToString();
                txtcmnd.Text = datanhanvien.Rows[i].Cells[9].Value.ToString();
            }
        }

        private void datanhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtngaysinh.Text = "";
            txtngaylam.Text = "";
            txtluong.Text = "";
            txtphucap.Text = "";
            txtcmnd.Text = "";
        }

        private void btnhientatca_Click(object sender, EventArgs e)
        {
            hientatca();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "" || txtsdt.Text == "" || txttennhanvien.Text == ""
                || txtmanhanvien.Text == "" || txtngaylam.Text == "" || txtngaysinh.Text == ""
                || txtluong.Text == "" || txtphucap.Text == "" || txtcmnd.Text == ""
                || txtgioitinh.Text == "")
            {
                MessageBox.Show("Các trường chưa được thêm đầy đủ");
            }
            else
            {
                int i;
                if (txtgioitinh.Text == "Nam" || txtgioitinh.Text == "nam")
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                DialogResult dialogResult = MessageBox.Show("Ban muon them nha cung cap nay", "Thong bao", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    try
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("themnhanvien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtmanhanvien.Text);
                        cmd.Parameters.AddWithValue("@ten", txttennhanvien.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                        cmd.Parameters.AddWithValue("@dt", txtsdt.Text);
                        cmd.Parameters.AddWithValue("@gioitinh", i);
                        cmd.Parameters.AddWithValue("@ngaysinh", txtngaysinh.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@ngaylam", txtngaylam.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@luongcb", txtluong.Text);
                        cmd.Parameters.AddWithValue("@phucap", txtphucap.Text);
                        cmd.Parameters.AddWithValue("@cmnd", txtcmnd.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Them thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Them that bai");
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã bị Giống nhau");
                    }

                    hientatca();

                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "" || txtsdt.Text == "" || txttennhanvien.Text == ""
               || txtmanhanvien.Text == "" || txtngaylam.Text == "" || txtngaysinh.Text == ""
               || txtluong.Text == "" || txtphucap.Text == "" || txtcmnd.Text == ""
               || txtgioitinh.Text == "")
            {
                MessageBox.Show("Các trường chưa được thêm đầy đủ");
            }
            else
            {
                int i;
                if (txtgioitinh.Text == "Nam" || txtgioitinh.Text == "nam")
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                DialogResult dialogResult = MessageBox.Show("Ban muon sua nha cung cap nay", "Thong bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("suanhanvien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtmanhanvien.Text);
                        cmd.Parameters.AddWithValue("@ten", txttennhanvien.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                        cmd.Parameters.AddWithValue("@dt", txtsdt.Text);
                        cmd.Parameters.AddWithValue("@gioitinh", i);
                        cmd.Parameters.AddWithValue("@ngaysinh", txtngaysinh.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@ngaylam", txtngaylam.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@luongcb", txtluong.Text);
                        cmd.Parameters.AddWithValue("@phucap", txtphucap.Text);
                        cmd.Parameters.AddWithValue("@cmnd", txtcmnd.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Sua thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Sua that bai");
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã bị Giống nhau");
                    }
                    hientatca();

                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "" || txtsdt.Text == "" || txttennhanvien.Text == ""
              || txtmanhanvien.Text == "" || txtngaylam.Text == "" || txtngaysinh.Text == ""
              || txtluong.Text == "" || txtphucap.Text == "" || txtcmnd.Text == ""
              || txtgioitinh.Text == "")
            {
                MessageBox.Show("Các trường chưa được thêm đầy đủ");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ban muon xoa nha cung cap nay", "Thong bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("xoanhanvien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtmanhanvien.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Xoa thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Xoa that bai");
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã bị Giống nhau");
                    }
                    hientatca();

                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            frprintnhanvien fr = new frprintnhanvien();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlDataAdapter sda = new SqlDataAdapter("timnhanvien",conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@ten", txttennhanvien.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datanhanvien.DataSource = dt;
                datanhanvien.Refresh();
            }
        }
    }
}
