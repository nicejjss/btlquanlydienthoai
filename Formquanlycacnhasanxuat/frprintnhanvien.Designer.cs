
namespace Formquanlycacnhasanxuat
{
    partial class frprintnhanvien
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
            this.report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnin = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.ActiveViewIndex = -1;
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report.Cursor = System.Windows.Forms.Cursors.Default;
            this.report.Location = new System.Drawing.Point(1, 41);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(761, 407);
            this.report.TabIndex = 0;
            this.report.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(23, 12);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 1;
            this.btnin.Text = "in";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(276, 13);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 22);
            this.textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập tuổi";
            // 
            // frprintnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.report);
            this.Name = "frprintnhanvien";
            this.Text = "frprintnhanvien";
            this.Load += new System.EventHandler(this.frprintnhanvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer report;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}