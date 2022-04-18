
namespace Formquanlycacnhasanxuat
{
    partial class frnhacungcap
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
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbten = new System.Windows.Forms.CheckBox();
            this.cbdiachi = new System.Windows.Forms.CheckBox();
            this.cbsdt = new System.Windows.Forms.CheckBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnhientatca = new System.Windows.Forms.Button();
            this.datanhacc = new System.Windows.Forms.DataGridView();
            this.qLCuaHangDienThoaiDataSet = new Formquanlycacnhasanxuat.QLCuaHangDienThoaiDataSet();
            this.qLCuaHangDienThoaiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.datanhacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDienThoaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDienThoaiDataSetBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtma.Location = new System.Drawing.Point(165, 52);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(176, 22);
            this.txtma.TabIndex = 1;
            this.txtma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtma_MouseClick);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(165, 102);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(176, 22);
            this.txtten.TabIndex = 2;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(165, 151);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(176, 22);
            this.txtdiachi.TabIndex = 3;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(165, 201);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(176, 22);
            this.txtsdt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ Nhà Cung Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Điện Thoại";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(15, 274);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 36);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(165, 274);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 36);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(307, 274);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(127, 36);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(165, 330);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 36);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lựa chọn tìm kiếm";
            // 
            // cbten
            // 
            this.cbten.AutoSize = true;
            this.cbten.Location = new System.Drawing.Point(40, 437);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(109, 21);
            this.cbten.TabIndex = 15;
            this.cbten.Text = "Tìm theo tên";
            this.cbten.UseVisualStyleBackColor = true;
            // 
            // cbdiachi
            // 
            this.cbdiachi.AutoSize = true;
            this.cbdiachi.Location = new System.Drawing.Point(40, 465);
            this.cbdiachi.Name = "cbdiachi";
            this.cbdiachi.Size = new System.Drawing.Size(130, 21);
            this.cbdiachi.TabIndex = 16;
            this.cbdiachi.Text = "Tìm theo địa chỉ";
            this.cbdiachi.UseVisualStyleBackColor = true;
            // 
            // cbsdt
            // 
            this.cbsdt.AutoSize = true;
            this.cbsdt.Location = new System.Drawing.Point(40, 492);
            this.cbsdt.Name = "cbsdt";
            this.cbsdt.Size = new System.Drawing.Size(117, 21);
            this.cbsdt.TabIndex = 17;
            this.cbsdt.Text = "Tìm theo SĐT";
            this.cbsdt.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(307, 330);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(127, 36);
            this.btntimkiem.TabIndex = 18;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnhientatca
            // 
            this.btnhientatca.Location = new System.Drawing.Point(15, 330);
            this.btnhientatca.Name = "btnhientatca";
            this.btnhientatca.Size = new System.Drawing.Size(127, 36);
            this.btnhientatca.TabIndex = 19;
            this.btnhientatca.Text = "Hiện tất cả";
            this.btnhientatca.UseVisualStyleBackColor = true;
            this.btnhientatca.Click += new System.EventHandler(this.btnhientatca_Click);
            // 
            // datanhacc
            // 
            this.datanhacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanhacc.Location = new System.Drawing.Point(469, 31);
            this.datanhacc.Name = "datanhacc";
            this.datanhacc.RowHeadersWidth = 51;
            this.datanhacc.RowTemplate.Height = 24;
            this.datanhacc.Size = new System.Drawing.Size(605, 495);
            this.datanhacc.TabIndex = 0;
            this.datanhacc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanhacc_CellClick);
            this.datanhacc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanhacc_CellContentClick);
            // 
            // qLCuaHangDienThoaiDataSet
            // 
            this.qLCuaHangDienThoaiDataSet.DataSetName = "QLCuaHangDienThoaiDataSet";
            this.qLCuaHangDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLCuaHangDienThoaiDataSetBindingSource
            // 
            this.qLCuaHangDienThoaiDataSetBindingSource.DataSource = this.qLCuaHangDienThoaiDataSet;
            this.qLCuaHangDienThoaiDataSetBindingSource.Position = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 28);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // frnhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 538);
            this.Controls.Add(this.btnhientatca);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.cbsdt);
            this.Controls.Add(this.cbdiachi);
            this.Controls.Add(this.cbten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.datanhacc);
            this.Name = "frnhacungcap";
            this.Text = "Nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frnhacungcap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.datanhacc, 0);
            this.Controls.SetChildIndex(this.txtma, 0);
            this.Controls.SetChildIndex(this.txtten, 0);
            this.Controls.SetChildIndex(this.txtdiachi, 0);
            this.Controls.SetChildIndex(this.txtsdt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnthem, 0);
            this.Controls.SetChildIndex(this.btnsua, 0);
            this.Controls.SetChildIndex(this.btnxoa, 0);
            this.Controls.SetChildIndex(this.btnclear, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cbten, 0);
            this.Controls.SetChildIndex(this.cbdiachi, 0);
            this.Controls.SetChildIndex(this.cbsdt, 0);
            this.Controls.SetChildIndex(this.btntimkiem, 0);
            this.Controls.SetChildIndex(this.btnhientatca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.datanhacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDienThoaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangDienThoaiDataSetBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbten;
        private System.Windows.Forms.CheckBox cbdiachi;
        private System.Windows.Forms.CheckBox cbsdt;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnhientatca;
        private System.Windows.Forms.DataGridView datanhacc;
        private System.Windows.Forms.BindingSource qLCuaHangDienThoaiDataSetBindingSource;
        private QLCuaHangDienThoaiDataSet qLCuaHangDienThoaiDataSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
    }
}

