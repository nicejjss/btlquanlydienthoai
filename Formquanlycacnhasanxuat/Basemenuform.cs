using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formquanlycacnhasanxuat
{
    public partial class Basemenuform : Form
    {
        public Basemenuform()
        {
            InitializeComponent();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "dangnhap")
                {
                    f.Show();
                }
            }
            for(int i = 0; i < Application.OpenForms.Count; i++)
            {
                if(Application.OpenForms[i].Name != "dangnhap")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban Muon Thoat Khong", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        { int i = 0;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frnhacungcap")
                {
                    f.BringToFront();
                    i++;
                    break;
                }
            }
            if (i == 0)
            {
                frnhacungcap fr = new frnhacungcap();
                fr.Show();
            }
        }

        private void hóaĐơnMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frhoadonmua")
                {
                    f.BringToFront();
                    i++;
                    break;
                }
            }
            if (i == 0)
            {
                frhoadonmua fr = new frhoadonmua();
                fr.Show();
            }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frnhanvien")
                {
                    f.BringToFront();
                    i++;
                    break;
                }
            }
            if (i == 0)
            {
                frnhanvien fr = new frnhanvien();
                fr.Show();
            }
        }
    }
}
