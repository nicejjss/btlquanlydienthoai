
namespace Formquanlycacnhasanxuat
{
    partial class frhoadonmua
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
            this.datahoadonmua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.txtnhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkhachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtngaylap = new System.Windows.Forms.DateTimePicker();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhientatca = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbtennhanvien = new System.Windows.Forms.CheckBox();
            this.cbtenkhachhang = new System.Windows.Forms.CheckBox();
            this.cbtenhang = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datahoadonmua)).BeginInit();
            this.SuspendLayout();
            // 
            // datahoadonmua
            // 
            this.datahoadonmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahoadonmua.Location = new System.Drawing.Point(449, 31);
            this.datahoadonmua.Name = "datahoadonmua";
            this.datahoadonmua.RowHeadersWidth = 51;
            this.datahoadonmua.RowTemplate.Height = 24;
            this.datahoadonmua.Size = new System.Drawing.Size(1072, 524);
            this.datahoadonmua.TabIndex = 1;
            this.datahoadonmua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datahoadonmua_CellClick);
            this.datahoadonmua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datahoadonmua_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(102, 49);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(75, 22);
            this.txtmahoadon.TabIndex = 3;
            this.txtmahoadon.TextChanged += new System.EventHandler(this.txtmahoadon_TextChanged);
            // 
            // txtnhanvien
            // 
            this.txtnhanvien.Location = new System.Drawing.Point(102, 98);
            this.txtnhanvien.Name = "txtnhanvien";
            this.txtnhanvien.Size = new System.Drawing.Size(146, 22);
            this.txtnhanvien.TabIndex = 5;
            this.txtnhanvien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtkhachhang
            // 
            this.txtkhachhang.Location = new System.Drawing.Point(102, 144);
            this.txtkhachhang.Name = "txtkhachhang";
            this.txtkhachhang.Size = new System.Drawing.Size(146, 22);
            this.txtkhachhang.TabIndex = 7;
            this.txtkhachhang.TextChanged += new System.EventHandler(this.txtkhachhang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khách Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(102, 195);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(146, 22);
            this.txtsdt.TabIndex = 11;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "SĐT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Lập";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtngaylap
            // 
            this.txtngaylap.CustomFormat = "dd/MM/yyyy";
            this.txtngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaylap.Location = new System.Drawing.Point(319, 51);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Size = new System.Drawing.Size(124, 22);
            this.txtngaylap.TabIndex = 13;
            this.txtngaylap.Value = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            this.txtngaylap.ValueChanged += new System.EventHandler(this.txtngaylap_ValueChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(102, 240);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(146, 22);
            this.txtdiachi.TabIndex = 15;
            this.txtdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 309);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 36);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(167, 309);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 36);
            this.btnsua.TabIndex = 24;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(316, 309);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(127, 36);
            this.btnxoa.TabIndex = 25;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhientatca
            // 
            this.btnhientatca.Location = new System.Drawing.Point(12, 362);
            this.btnhientatca.Name = "btnhientatca";
            this.btnhientatca.Size = new System.Drawing.Size(127, 36);
            this.btnhientatca.TabIndex = 26;
            this.btnhientatca.Text = "Hiện tất cả";
            this.btnhientatca.UseVisualStyleBackColor = true;
            this.btnhientatca.Click += new System.EventHandler(this.btnhientatca_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(167, 362);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 36);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(316, 488);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(127, 36);
            this.btntimkiem.TabIndex = 28;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cbtennhanvien
            // 
            this.cbtennhanvien.AutoSize = true;
            this.cbtennhanvien.Location = new System.Drawing.Point(79, 470);
            this.cbtennhanvien.Name = "cbtennhanvien";
            this.cbtennhanvien.Size = new System.Drawing.Size(189, 21);
            this.cbtennhanvien.TabIndex = 29;
            this.cbtennhanvien.Text = "Tìm Theo Tên Nhân Viên";
            this.cbtennhanvien.UseVisualStyleBackColor = true;
            this.cbtennhanvien.CheckedChanged += new System.EventHandler(this.cbtennhanvien_CheckedChanged);
            // 
            // cbtenkhachhang
            // 
            this.cbtenkhachhang.AutoSize = true;
            this.cbtenkhachhang.Location = new System.Drawing.Point(79, 497);
            this.cbtenkhachhang.Name = "cbtenkhachhang";
            this.cbtenkhachhang.Size = new System.Drawing.Size(201, 21);
            this.cbtenkhachhang.TabIndex = 30;
            this.cbtenkhachhang.Text = "Tìm Theo Tên Khách Hàng";
            this.cbtenkhachhang.UseVisualStyleBackColor = true;
            this.cbtenkhachhang.CheckedChanged += new System.EventHandler(this.cbtenkhachhang_CheckedChanged);
            // 
            // cbtenhang
            // 
            this.cbtenhang.AutoSize = true;
            this.cbtenhang.Location = new System.Drawing.Point(79, 524);
            this.cbtenhang.Name = "cbtenhang";
            this.cbtenhang.Size = new System.Drawing.Size(157, 21);
            this.cbtenhang.TabIndex = 31;
            this.cbtenhang.Text = "Tìm Theo Tên Hàng";
            this.cbtenhang.UseVisualStyleBackColor = true;
            this.cbtenhang.CheckedChanged += new System.EventHandler(this.cbtenhang_CheckedChanged);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(316, 362);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(127, 36);
            this.btnprint.TabIndex = 32;
            this.btnprint.Text = "In";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // frhoadonmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 567);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cbtenhang);
            this.Controls.Add(this.cbtenkhachhang);
            this.Controls.Add(this.cbtennhanvien);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnhientatca);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtngaylap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtkhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmahoadon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datahoadonmua);
            this.Name = "frhoadonmua";
            this.Text = "Hoá Đơn Mua";
            this.Load += new System.EventHandler(this.frhoadonmua_Load);
            this.Controls.SetChildIndex(this.datahoadonmua, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtmahoadon, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnhanvien, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtkhachhang, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtsdt, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtngaylap, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtdiachi, 0);
            this.Controls.SetChildIndex(this.btnthem, 0);
            this.Controls.SetChildIndex(this.btnsua, 0);
            this.Controls.SetChildIndex(this.btnxoa, 0);
            this.Controls.SetChildIndex(this.btnhientatca, 0);
            this.Controls.SetChildIndex(this.btnclear, 0);
            this.Controls.SetChildIndex(this.btntimkiem, 0);
            this.Controls.SetChildIndex(this.cbtennhanvien, 0);
            this.Controls.SetChildIndex(this.cbtenkhachhang, 0);
            this.Controls.SetChildIndex(this.cbtenhang, 0);
            this.Controls.SetChildIndex(this.btnprint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.datahoadonmua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datahoadonmua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.TextBox txtnhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtngaylap;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhientatca;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.CheckBox cbtennhanvien;
        private System.Windows.Forms.CheckBox cbtenkhachhang;
        private System.Windows.Forms.CheckBox cbtenhang;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Timer timer1;
    }
}