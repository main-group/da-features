namespace AdminControls
{
    partial class KeSachThuVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fpnlHienThi = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTenKeSach = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlHienThi
            // 
            this.fpnlHienThi.BackColor = System.Drawing.Color.LemonChiffon;
            this.fpnlHienThi.Location = new System.Drawing.Point(13, 13);
            this.fpnlHienThi.Name = "fpnlHienThi";
            this.fpnlHienThi.Size = new System.Drawing.Size(260, 328);
            this.fpnlHienThi.TabIndex = 0;
            // 
            // lblTenKeSach
            // 
            this.lblTenKeSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKeSach.Location = new System.Drawing.Point(3, 13);
            this.lblTenKeSach.Name = "lblTenKeSach";
            this.lblTenKeSach.Size = new System.Drawing.Size(254, 33);
            this.lblTenKeSach.TabIndex = 0;
            this.lblTenKeSach.Text = "lblTenKeSach";
            this.lblTenKeSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTieuDe.Controls.Add(this.lblTenKeSach);
            this.pnlTieuDe.Location = new System.Drawing.Point(13, 362);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(260, 59);
            this.pnlTieuDe.TabIndex = 1;
            // 
            // KeSachThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.fpnlHienThi);
            this.Name = "KeSachThuVien";
            this.Size = new System.Drawing.Size(286, 434);
            this.Load += new System.EventHandler(this.KeSachThuVien_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlHienThi;
        private System.Windows.Forms.Label lblTenKeSach;
        private System.Windows.Forms.Panel pnlTieuDe;
    }
}
