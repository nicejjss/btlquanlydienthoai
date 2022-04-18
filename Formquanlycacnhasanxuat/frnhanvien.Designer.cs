
namespace Formquanlycacnhasanxuat
{
    partial class frnhanvien
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
            this.datanhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtngaylam = new System.Windows.Forms.DateTimePicker();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnhientatca = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datanhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // datanhanvien
            // 
            this.datanhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanhanvien.Location = new System.Drawing.Point(527, 31);
            this.datanhanvien.Name = "datanhanvien";
            this.datanhanvien.RowHeadersWidth = 51;
            this.datanhanvien.RowTemplate.Height = 24;
            this.datanhanvien.Size = new System.Drawing.Size(1025, 507);
            this.datanhanvien.TabIndex = 1;
            this.datanhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.datanhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanhanvien_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Vào Làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lương Cơ Bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phụ Cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "CMND";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(116, 43);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(136, 22);
            this.txtmanhanvien.TabIndex = 12;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(116, 86);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(136, 22);
            this.txttennhanvien.TabIndex = 13;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(116, 133);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(136, 22);
            this.txtgioitinh.TabIndex = 14;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(116, 174);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(136, 22);
            this.txtdiachi.TabIndex = 15;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(116, 216);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(136, 22);
            this.txtsdt.TabIndex = 16;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaysinh.Location = new System.Drawing.Point(385, 45);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(108, 22);
            this.txtngaysinh.TabIndex = 17;
            // 
            // txtngaylam
            // 
            this.txtngaylam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaylam.Location = new System.Drawing.Point(385, 86);
            this.txtngaylam.Name = "txtngaylam";
            this.txtngaylam.Size = new System.Drawing.Size(108, 22);
            this.txtngaylam.TabIndex = 18;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(385, 140);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(136, 22);
            this.txtluong.TabIndex = 19;
            // 
            // txtphucap
            // 
            this.txtphucap.Location = new System.Drawing.Point(385, 177);
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.Size = new System.Drawing.Size(136, 22);
            this.txtphucap.TabIndex = 20;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(385, 221);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(136, 22);
            this.txtcmnd.TabIndex = 21;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(34, 277);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(106, 42);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(196, 277);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(106, 42);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(362, 277);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(106, 42);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(34, 341);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(106, 42);
            this.btnclear.TabIndex = 25;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnhientatca
            // 
            this.btnhientatca.Location = new System.Drawing.Point(196, 341);
            this.btnhientatca.Name = "btnhientatca";
            this.btnhientatca.Size = new System.Drawing.Size(106, 42);
            this.btnhientatca.TabIndex = 26;
            this.btnhientatca.Text = "Hiện Tất Cả";
            this.btnhientatca.UseVisualStyleBackColor = true;
            this.btnhientatca.Click += new System.EventHandler(this.btnhientatca_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(34, 479);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(106, 42);
            this.btnin.TabIndex = 27;
            this.btnin.Text = "In DSNV";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(34, 412);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(106, 42);
            this.btntimkiem.TabIndex = 29;
            this.btntimkiem.Text = "Tìm Kiếm Tên";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // frnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 550);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnhientatca);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txtphucap);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtngaylam);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datanhanvien);
            this.Name = "frnhanvien";
            this.Text = "frnhanvien";
            this.Load += new System.EventHandler(this.frnhanvien_Load);
            this.Controls.SetChildIndex(this.datanhanvien, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtmanhanvien, 0);
            this.Controls.SetChildIndex(this.txttennhanvien, 0);
            this.Controls.SetChildIndex(this.txtgioitinh, 0);
            this.Controls.SetChildIndex(this.txtdiachi, 0);
            this.Controls.SetChildIndex(this.txtsdt, 0);
            this.Controls.SetChildIndex(this.txtngaysinh, 0);
            this.Controls.SetChildIndex(this.txtngaylam, 0);
            this.Controls.SetChildIndex(this.txtluong, 0);
            this.Controls.SetChildIndex(this.txtphucap, 0);
            this.Controls.SetChildIndex(this.txtcmnd, 0);
            this.Controls.SetChildIndex(this.btnthem, 0);
            this.Controls.SetChildIndex(this.btnsua, 0);
            this.Controls.SetChildIndex(this.btnxoa, 0);
            this.Controls.SetChildIndex(this.btnclear, 0);
            this.Controls.SetChildIndex(this.btnhientatca, 0);
            this.Controls.SetChildIndex(this.btnin, 0);
            this.Controls.SetChildIndex(this.btntimkiem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.datanhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datanhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
        private System.Windows.Forms.DateTimePicker txtngaylam;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnhientatca;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntimkiem;
    }
}