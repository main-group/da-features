namespace da_features
{
    partial class FrmTestHienThiKeSach
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
            this.dataSet_DB_DA_FEATURES = new da_features.DataSet_DB_DA_FEATURES();
            this.keSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keSachTableAdapter = new da_features.DataSet_DB_DA_FEATURESTableAdapters.KeSachTableAdapter();
            this.tableAdapterManager = new da_features.DataSet_DB_DA_FEATURESTableAdapters.TableAdapterManager();
            this.fpnlDSKeSach = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DB_DA_FEATURES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_DB_DA_FEATURES
            // 
            this.dataSet_DB_DA_FEATURES.DataSetName = "DataSet_DB_DA_FEATURES";
            this.dataSet_DB_DA_FEATURES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keSachBindingSource
            // 
            this.keSachBindingSource.DataMember = "KeSach";
            this.keSachBindingSource.DataSource = this.dataSet_DB_DA_FEATURES;
            // 
            // keSachTableAdapter
            // 
            this.keSachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KeSachTableAdapter = this.keSachTableAdapter;
            this.tableAdapterManager.SachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = da_features.DataSet_DB_DA_FEATURESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ViTriSachTableAdapter = null;
            // 
            // fpnlDSKeSach
            // 
            this.fpnlDSKeSach.AutoScroll = true;
            this.fpnlDSKeSach.Location = new System.Drawing.Point(12, 12);
            this.fpnlDSKeSach.Name = "fpnlDSKeSach";
            this.fpnlDSKeSach.Size = new System.Drawing.Size(1231, 647);
            this.fpnlDSKeSach.TabIndex = 0;
            // 
            // FrmTestHienThiKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 671);
            this.Controls.Add(this.fpnlDSKeSach);
            this.Name = "FrmTestHienThiKeSach";
            this.Text = "FrmTestHienThiKeSach";
            this.Load += new System.EventHandler(this.FrmTestHienThiKeSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DB_DA_FEATURES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_DB_DA_FEATURES dataSet_DB_DA_FEATURES;
        private System.Windows.Forms.BindingSource keSachBindingSource;
        private DataSet_DB_DA_FEATURESTableAdapters.KeSachTableAdapter keSachTableAdapter;
        private DataSet_DB_DA_FEATURESTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel fpnlDSKeSach;
    }
}