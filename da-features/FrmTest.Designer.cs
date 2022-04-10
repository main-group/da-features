namespace da_features
{
    partial class FrmTest
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
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.kstv = new AdminControls.KeSachThuVien();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(223, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(12, 12);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(205, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // kstv
            // 
            this.kstv.BackColor = System.Drawing.Color.LightBlue;
            this.kstv.Location = new System.Drawing.Point(12, 131);
            this.kstv.Name = "kstv";
            this.kstv.Size = new System.Drawing.Size(286, 434);
            this.kstv.TabIndex = 0;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.kstv);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdminControls.KeSachThuVien kstv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenSach;

    }
}