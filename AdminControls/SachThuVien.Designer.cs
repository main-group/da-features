namespace AdminControls
{
    partial class SachThuVien
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
            this.lblTenSach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenSach
            // 
            this.lblTenSach.Location = new System.Drawing.Point(3, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(118, 42);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "lblTenSach";
            this.lblTenSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SachThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblTenSach);
            this.Name = "SachThuVien";
            this.Size = new System.Drawing.Size(124, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenSach;
    }
}
